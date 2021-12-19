using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using frequencychanger;

namespace spoolersim
{
    public partial class FrequencyChanger : Form
    {
        private Communication mCommunicator;

        static int mSelectedSampleTime;
        static int mTestRunning;
        static DataPoint _datapoint;

        static int[] iarrSampleTimes =  { 1000,500,250,200,100 };

        enum mConfigurationCodes { FREQ=0, SHIFT=1, AMPOFFSET=2,  MODE=3, ALL=4};

        enum mTestStates{ STOPPED = 0, HOLD = 1, RUNNING = 2};
 
        static Thread mWorkerThread;

        public FrequencyChanger()
        {

            InitializeComponent();

            // Variable inits


            // --> Manual
            // Component starting state
            tabControl1.Enabled = false ;
            rbuttonModePwm16kHz.Select();
            rbuttonStateU2.Select();
            rbuttonStateV2.Select();
            rbuttonStateW2.Select();


            tbarFrequencyMaster.Value = 5;
            tbarShiftU.Value = 0;
            tbarShiftV.Value = 120;
            tbarShiftW.Value = 240;

            tbarAmplitudeU.Value = 20;
            tbarAmplitudeV.Value = 20;
            tbarAmplitudeW.Value = 20;

            tbarOffsetU.Value = 0;
            tbarOffsetV.Value = 0;
            tbarOffsetW.Value = 0;

            cboxSwitchUV.Enabled = false;

            // --> Curve
            mSelectedSampleTime = 0;
            tboxSampleSpeed.Text = "" + iarrSampleTimes[mSelectedSampleTime];
            EnableSectionsCurve(true);

            mTestRunning = (int)mTestStates.STOPPED;


            // Common
            mCommunicator = new Communication();


        }
        private void Log(string status ) {
            labelStatusLine.Text = status;
            statusLine.Refresh();
        }


        private void EnableSectionsManual(Boolean state) {
            if (state)
            {

                tboxFrequencyMaster.Enabled = true;
                tbarFrequencyMaster.Enabled = true;
            }
            else {


                tboxFrequencyMaster.Enabled = false;
                tbarFrequencyMaster.Enabled = false;

            }
        }

        private void Limiter(TrackBar bar, TextBox box)
        {
            int currentvalue = bar.Value;
            if (currentvalue > bar.Maximum)
            {
                currentvalue = bar.Maximum;
            }
            else if (currentvalue < bar.Minimum)
            {
                currentvalue = bar.Minimum;
            }
            bar.Value = currentvalue;
            box.Text = "" + currentvalue;
        }

        private async void ConfigureDeviceFromFields(mConfigurationCodes config) {
            int status = 0xFF;
            int freqMaster=0, stateU=0, stateV=0, stateW=0, shiftU=0, shiftV = 0, shiftW = 0, ampU=0, ampV = 0, ampW = 0, offU = 0, offV = 0, offW = 0, mode = 0, temp;
            try
            {   
                // Frequency
                if (config == mConfigurationCodes.ALL || config == mConfigurationCodes.FREQ)
                {
                    // If Lock to Master is Checked, Use the Frequency from the big bar
                    freqMaster = Int32.Parse(tboxFrequencyMaster.Text);

                    // ---- U ----
                    if (rbuttonStateU2.Checked)
                    {
                        stateU = 2;
                    }
                    else if (rbuttonStateU1.Checked)
                    {
                        stateU = 1;
                    }
                    else {
                        stateU = 0;
                    }

                    // ---- V ----
                    if (rbuttonStateV2.Checked)
                    {
                        stateV = 2;
                    }
                    else if (rbuttonStateV1.Checked)
                    {
                        stateV = 1;
                    }
                    else
                    {
                        stateV = 0;
                    }

                    // ---- W ----
                    if (rbuttonStateW2.Checked)
                    {
                        stateW = 2;
                    }
                    else if (rbuttonStateW1.Checked)
                    {
                        stateW = 1;
                    }
                    else
                    {
                        stateW = 0;
                    }        
                }

                // Shift
                if (config == mConfigurationCodes.ALL || config == mConfigurationCodes.SHIFT)
                {
                    shiftU = Int32.Parse(tboxShiftU.Text);
                    shiftV = Int32.Parse(tboxShiftV.Text);
                    shiftW = Int32.Parse(tboxShiftW.Text);
                }

                // Amplitude 
                if (config == mConfigurationCodes.ALL || config == mConfigurationCodes.AMPOFFSET)
                {
                    ampU = Int32.Parse(tboxAmplitudeU.Text);
                    ampV = Int32.Parse(tboxAmplitudeV.Text);
                    ampW = Int32.Parse(tboxAmplitudeW.Text);

                    offU = Int32.Parse(tboxOffsetU.Text);
                    offV = Int32.Parse(tboxOffsetV.Text);
                    offW = Int32.Parse(tboxOffsetW.Text);
                }



                // Mode 
                if (config == mConfigurationCodes.ALL || config == mConfigurationCodes.MODE) {
                    if (rbuttonModeHtl.Checked)
                    {
                        mode = 0;
                    }
                    else if (rbuttonModePwm16kHz.Checked)
                    {
                        mode = 1;
                    }
                    else if (rbuttonModePwm8kHz.Checked)
                    {
                        mode = 2;
                    }
                    else if (rbuttonModeStoeber.Checked)
                    {
                        mode = 3;
                    }
                    else if (rbuttonModePwm4kHz.Checked)
                    {
                        mode = 4;
                    }
                    else if (rbuttonModePwm2kHz.Checked) {
                        mode = 8;
                    }

                }
                if (cboxSwitchUV.Checked) {
                    temp = stateU;
                    stateU = stateV;
                    stateV = temp;

                    temp = shiftU;
                    shiftU = shiftV;
                    shiftV = temp;

                    temp = ampU;
                    ampU = ampV;
                    ampV = temp;

                    temp = offU;
                    offU = offV;
                    offV = temp;
                }


                // Send data
                switch (config)
                {
                    case mConfigurationCodes.FREQ:
                        status = await mCommunicator.SetFrequencies(freqMaster, stateU, stateV, stateW);
                        break;
                    case mConfigurationCodes.SHIFT:
                        status = await mCommunicator.SetShifts(shiftU, shiftV, shiftW);
                        break;
                    case mConfigurationCodes.AMPOFFSET:
                        status = await mCommunicator.SetOffsetsAndAmplitudes(ampU, ampV, ampW,offU, offV, offW);
                        break;
                    case mConfigurationCodes.MODE:
                        status = await mCommunicator.SetMode(mode);
                        break;
                    case mConfigurationCodes.ALL:
                        status = await mCommunicator.SetAll(freqMaster,stateU, stateV, stateW, shiftU, shiftV, shiftW, ampU, ampV, ampW, offU, offV, offW, mode);
                        break;

                }

                Log(String.Format("Status: {0}", status));
            }
            catch (Exception ex) {
                Log(String.Format("Status: Exception {0}", ex.ToString()));
            }
        }

        private void buttonSetAllCallback(object sender, EventArgs e)
        {
            ConfigureDeviceFromFields(mConfigurationCodes.ALL);
        }

        private void rbuttonStateChangedCallback(object semder, EventArgs e)
        {

            if (cboxOnTheFly.Checked)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.FREQ);
            }
        }

        private void tbarAmpOffsetLimiterCallback(object sender, System.EventArgs e)
        {
            // Amplitudes
            if (sender == tbarAmplitudeU)
            {
                Limiter(tbarAmplitudeU, tboxAmplitudeU);
            }
            else if(sender == tbarAmplitudeV) {
                Limiter(tbarAmplitudeV, tboxAmplitudeV);
            }
            else if (sender == tbarAmplitudeW)
            {
                Limiter(tbarAmplitudeW, tboxAmplitudeW);
            }

            // Offsets
            else if (sender == tbarOffsetU)
            {
                Limiter(tbarOffsetU, tboxOffsetU);
            }
            else if (sender == tbarOffsetV)
            {
                Limiter(tbarOffsetV, tboxOffsetV);
            }
            else if (sender == tbarOffsetW)
            {
                Limiter(tbarOffsetW, tboxOffsetW);
            }


            if (cboxOnTheFly.Checked)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.AMPOFFSET);
            }

            this.updateManualChart();
        }



        private void tbarFrequencyLimiterCallback(object sender, System.EventArgs e)
        {
            if (sender == tbarFrequencyMaster)
            {
                Limiter(tbarFrequencyMaster, tboxFrequencyMaster);
            }
           
            Log(String.Format("Frequency set to {0}",((TrackBar)(sender)).Value));

            if (cboxOnTheFly.Checked)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.FREQ);
            }
        }

        private void tbarShiftLimiterCallback(object sender, System.EventArgs e)
        {
            if (sender == tbarShiftU)
            {
                Limiter(tbarShiftU, tboxShiftU);
            }
            else if (sender == tbarShiftV)
            {
                Limiter(tbarShiftV, tboxShiftV);
            }
            else if (sender == tbarShiftW)
            {
                Limiter(tbarShiftW, tboxShiftW);
            }

            Log(String.Format("Shift set to {0}", ((TrackBar)(sender)).Value));

            if (cboxOnTheFly.Checked)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.SHIFT);
            }

            this.updateManualChart();
        }


        private void tboxFrequencyLimiterCallback(object sender, EventArgs e)
        {

            if (sender == tboxFrequencyMaster)
            {
                string currenttext = tboxFrequencyMaster.Text;
                if (currenttext != "")
                {
                    try
                    {
                        tbarFrequencyMaster.Value = Convert.ToInt32(currenttext);
                    }
                    catch (Exception ex)
                    {
                        Log("Exception: could not set Frequency");
                    }
                }
            }
        }

        private void tboxShiftLimiterCallback(object sender, EventArgs e)
        {

            if (sender == tboxShiftU)
            {

                string currenttext = tboxShiftU.Text;
                if (currenttext != "")
                {
                    try
                    {
                        tbarShiftU.Value = Convert.ToInt32(currenttext);
                    }
                    catch (Exception ex)
                    {
                        Log("Exception: could not set Shift U");
                    }
                }
            }
            else if (sender == tboxShiftV)
            {

                string currenttext = tboxShiftV.Text;
                if (currenttext != "")
                {
                    try
                    {
                        tbarShiftV.Value = Convert.ToInt32(currenttext);
                    }
                    catch (Exception ex)
                    {
                        Log("Exception: could not set Shift V");
                    }
                }
            }
            else if (sender == tboxShiftW)
            {

                string currenttext = tboxShiftW.Text;
                if (currenttext != "")
                {
                    try
                    {
                        tbarShiftW.Value = Convert.ToInt32(currenttext);
                    }
                    catch (Exception ex)
                    {
                        Log("Exception: could not set Shift W");
                    }
                }
            }
        }

        private void cboxOnChangeCallback(object sender, EventArgs e)
        {
            if (sender == cboxOnTheFly) {

                cboxSwitchUV.Enabled = cboxOnTheFly.Checked;

            }
            else if (sender == cboxSwitchUV)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.ALL);

            }
        }


        private void rbuttonSignalModeCallback(object sender, EventArgs e)
        {
            if (cboxOnTheFly.Checked)
            {
                ConfigureDeviceFromFields(mConfigurationCodes.MODE);
            }
            
            /*
            foreach (Control control in this.gboxSignalType.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {   radio.
                        result1 = radio.Text;
                    }
                }
            }*/
        }


        /* Serial Port handlers*/

        private void buttonSerialPortRefreshCallback(object sender, EventArgs e)
        {
            string[] ports = mCommunicator.GetPortNames();
            cboxSerialPort.Items.Clear();

            foreach (string port in ports)
            {
                ComboboxItem cbi = new ComboboxItem();
                cbi.Text = port;
                cbi.Value = port;

                cboxSerialPort.Items.Add(cbi);
                cboxSerialPort.SelectedIndex = 0;
            }
        }
        private void buttonSerialPortConnectCallback(object sender, EventArgs e)
        {

            if (!mCommunicator.mSerialPortOpen && cboxSerialPort.SelectedItem != null)
            {
                string selecte_datapointort = cboxSerialPort.SelectedItem.ToString();
                mCommunicator.OpenPort(selecte_datapointort);
            }
            else
            {
                mCommunicator.ClosePort();
            }

            // Update UX
            if (mCommunicator.mSerialPortOpen)
            {
                tabControl1.Enabled = true;
                Log("Port is Open");
                buttonSerialPortConnect.Text = "Disconnect";
                cboxSerialPort.Enabled = false;

            }
            else {
                tabControl1.Enabled = false;
                buttonSerialPortConnect.Text = "Connect";
                Log("Port has been closed");
                cboxSerialPort.Enabled = true;
   
            }
          
        }




        /***------------------------------------------------------------------
        #
        #                      HERE STARTS "Curve" PAGE 
        #   
        #--------------------------------------------------------------------*/
        private void chartFrequencyMouseMoveCallback(object sender, MouseEventArgs e) {
            ChartArea ca = chartCurve.ChartAreas[0];
            Axis ax = ca.AxisX;
            Axis ay = ca.AxisY;

            if (_datapoint != null)
            {
                Series s = chartCurve.Series[0];

                try { 
                    double dx = ax.PixelPositionToValue(e.X);
                    double dy = ay.PixelPositionToValue(e.Y);

                    _datapoint.XValue = _datapoint.XValue;
                    //_datapoint.XValue = (int)dx;

                    if (dy > 1600)
                        dy = 1600;
                    else if (dy < 1)
                        dy = 1;
                    _datapoint.YValues[0] = (int)dy;
                }
                catch(Exception ex)
                {
                    Log("Out of range");
                }
            }
        }
        private void chartFrequencyMouseUpCallback(object sender, MouseEventArgs e)
        {

            _datapoint = null;

        }
        private void chartFrequencyMouseDownCallback(object sender, MouseEventArgs e)
        {
          
            var r = chartCurve.HitTest(e.X, e.Y);

            if (r.ChartElementType == ChartElementType.DataPoint && mTestRunning !=(int)mTestStates.RUNNING)
            {
                _datapoint = chartCurve.Series[0].Points[r.PointIndex];
            }
        }
        private void chartFrequencyMouseWheelCallback(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                    chartCurve.ChartAreas[0].AxisY.Interval =  50;
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = (int)(xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4);
                    var posXFinish = (int)(xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4);
                    var posYStart = (int)(yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4);
                    var posYFinish = (int)(yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4);


              
                    chartCurve.ChartAreas[0].AxisY.Interval = (int)(chartCurve.ChartAreas[0].AxisY.Interval/2);
                    if (chartCurve.ChartAreas[0].AxisY.Interval < 1) {
                        chartCurve.ChartAreas[0].AxisY.Interval = 1;
                    }


                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }

        private void updateManualChart() {
            try
            {
                var seriesU = this.chartManual.Series[0];
                var seriesV = this.chartManual.Series[1];
                var seriesW = this.chartManual.Series[2];

                seriesU.Points.Clear();
                seriesV.Points.Clear();
                seriesW.Points.Clear();

                int samples = 360;
                int interval = 1;
                int frequency = 1;//Int32.Parse(tboxFrequencyMaster.Text);

                double step = 2.0d / samples;

                double phaseU = Int32.Parse(tboxShiftU.Text);
                double phaseV = Int32.Parse(tboxShiftV.Text);
                double phaseW = Int32.Parse(tboxShiftW.Text);

                int AmplitudeU = Int32.Parse(tboxAmplitudeU.Text); 
                int AmplitudeV = Int32.Parse(tboxAmplitudeV.Text); 
                int AmplitudeW = Int32.Parse(tboxAmplitudeW.Text); 

                for (int i = 0; i < samples; i = i + interval)
                {
                    seriesU.Points.AddXY(i, AmplitudeU * Math.Sin(frequency*i * step * Math.PI + (Math.PI * phaseU / (samples / 2))));
                    seriesV.Points.AddXY(i, AmplitudeV * Math.Sin(frequency*i * step * Math.PI + (Math.PI * phaseV / (samples / 2))));
                    seriesW.Points.AddXY(i, AmplitudeW * Math.Sin(frequency*i * step * Math.PI + (Math.PI * phaseW / (samples / 2))));
                }

                chartManual.Invalidate();
            }
            catch (Exception e) {
                   // Just don't draw
            }

        }



        private void formManualoadCallback(object sender, EventArgs e)
        {
            updateManualChart();
        }


        private void formCurveLoadCallback(object sender, EventArgs e)
        {
            chartCurve.Series.Clear();
            var series1 = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Frequency change / s",
                Color = System.Drawing.Color.DarkBlue,
                IsVisibleInLegend = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            this.chartCurve.Series.Add(series1);

            int samples = 60;
            int interval = 1;

            double step = 2.0d / samples;

            //chartFrequency.ChartAreas[0].AxisX.Interval = 1;
            chartCurve.ChartAreas[0].AxisY.Maximum = 1600;
            chartCurve.ChartAreas[0].AxisY.Minimum = -50;

            chartCurve.ChartAreas[0].AxisY.Interval = 50;


            int maxamp = 50;

            series1.ChartType = SeriesChartType.Line;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.MarkerSize = 10;

            for (int i = 0; i < samples; i = i+interval)
            {
                int value = (int)((maxamp * Math.Sin(i * step * Math.PI+( Math.PI*3/2)) + maxamp));
                if (value < 1) {
                    value = 1;
                }
                series1.Points.AddXY(i, value);
            }

            this.chartCurve.Series[0].ToolTip = "Y Value: #VALY";
            chartCurve.Invalidate(); 
        }
        public delegate void InvokeDelegate(int i);
        public delegate void InvokeDelegatePrint(string s);
        public delegate void InvokeDelegateResetPointsColor();
        public delegate void InvokeDelegateEnableSectionsCurve(Boolean b);
        public delegate void InvokeDelegatePrintCurrentTestVariables(string t, string freq);

        public void printCurrentTestVariables(string t, string freq) {
            labelTimeVariable.Text = t;
            labelFrequencyVariable.Text = freq;
        }

        public void setDataPointRed(int i)
        {
            chartCurve.Series[0].Points[i].Color = Color.Red;
        }
        public void resetDataPointsColors() {

            foreach (DataPoint point in chartCurve.Series[0].Points)
            {
                point.Color = Color.DarkBlue;
            }
        }
        public void EnableSectionsCurve(Boolean state) {
            if (state)
            {
                chartCurve.BorderlineColor = System.Drawing.Color.Black;
                buttonIncrease.Enabled = true;
                buttonDecrease.Enabled = true;
                buttonStart.Enabled = true;
                buttonStop.Enabled = false;
                buttonHold.Enabled = false;

            }
            else {

                chartCurve.BorderlineColor = System.Drawing.Color.Red;
                buttonIncrease.Enabled = false;
                buttonDecrease.Enabled = false;
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonHold.Enabled = false;

            }
        }
        private void mWorkerThreadFunction()
        {

            long timediff = 0;
            try
            {
                var points = chartCurve.Series[0].Points;
                int length = points.Count;
                int index = 0;

                int sampletime = iarrSampleTimes[mSelectedSampleTime];

                int step = 1000/ sampletime;
                int subindex = 0;

                int sampledfrequency = 0;

                const string format1 = "{0}:{1:000}";
                const string format2 = "{0} Hz";
                long timepassed = 0;
                byte[] packet = new byte[6];
                // TODO sampletime influences loop speed, need to check
                while (mTestRunning != (int)mTestStates.STOPPED) {
                    
                    long now = DateTime.Now.Millisecond;    // TODO convert to nanotime
                    if (mTestRunning == (int)mTestStates.RUNNING)
                    {
                        if (index < length)
                        {
                            --subindex;
                            if (subindex <= 0)
                            {
                              
                                BeginInvoke(new InvokeDelegate(setDataPointRed), index);
                                sampledfrequency = (int)points[index].YValues[0];
                                subindex = step;
                                ++index;
                            }
                            else {

                                sampledfrequency = (int)(points[index-1].YValues[0]+ (points[index].YValues[0]-points[index-1].YValues[0])/(subindex+1));
                              
                            }

                            timepassed += sampletime;

                            // Set Frequency and enable all outputs
                            mCommunicator.SetFrequencies(sampledfrequency, 2, 2, 2);
                      
                            //<<  add communication here, deliver sampledfrequency >>
                            BeginInvoke(new InvokeDelegatePrintCurrentTestVariables(printCurrentTestVariables), string.Format(format1,timepassed/1000,timepassed%1000), string.Format(format2, sampledfrequency) );     // TODO


                            timediff = (DateTime.Now.Millisecond - now);
                            if (timediff < sampletime)
                            {
                                Thread.Sleep((int)(sampletime - timediff));
                            }
                            else
                            {
                                BeginInvoke(new InvokeDelegatePrint(Log), "Sampletime is too short!");
                            }
                        }
                        else
                        {
                            BeginInvoke(new InvokeDelegateResetPointsColor(resetDataPointsColors));

                            if (cboxRepeatIndefinitely.Checked == true)
                            {
                                index = 0;

                            }
                            else {
                                
                                mTestRunning = (int)mTestStates.STOPPED;
                                BeginInvoke(new InvokeDelegateEnableSectionsCurve(EnableSectionsCurve),true);
                            
                            }
                           
                        }
                    }
                    else {
                        Thread.Sleep(10);     // Hold
                    }

                }
            }
            catch(Exception ex)
            {
                BeginInvoke(new InvokeDelegatePrint(Log), "Exception: test crashed");
            }
            
        }

        private void buttonStartCallback(object sender, EventArgs e)
        {

            string buttontext = ((Button)sender).Text;

            if (buttontext == "Start" ) {

                if (mTestRunning == (int)mTestStates.STOPPED)
                {

                   
                    mTestRunning = (int)mTestStates.RUNNING;
                    EnableSectionsCurve(false);

                    mWorkerThread = new Thread(new ThreadStart(mWorkerThreadFunction));
                    mWorkerThread.Start();

                   
                }

                else if (mTestRunning == (int)mTestStates.HOLD)
                {
                    mTestRunning = (int)mTestStates.RUNNING;
                   
                }

                buttonStart.Enabled = false;
                buttonHold.Enabled = true;
                buttonStop.Enabled = true;

                gboxMode.Enabled = true;
            }
            else if (buttontext == "Hold" && (mTestRunning == (int)mTestStates.RUNNING)) {

                mTestRunning = (int)mTestStates.HOLD;
                gboxMode.Enabled = true;

                buttonStart.Enabled = true;
                buttonHold.Enabled = false;
                buttonStop.Enabled = true;

            }
            else if(buttontext == "Stop" && (mTestRunning != (int)mTestStates.STOPPED)) {

                mTestRunning = (int)mTestStates.STOPPED;
                resetDataPointsColors();
                EnableSectionsCurve(true);

              

                if (mWorkerThread != null)
                {
                    mWorkerThread.Join();
                }

                buttonStart.Enabled = true;
                buttonHold.Enabled = false;
                buttonStop.Enabled = false;
            }

        }


        private void sampleFrequencyCallback(object sender, EventArgs e)
        {

            string buttontext = ((Button)sender).Text;

            // Increase
            if (buttontext == ">") {

                mSelectedSampleTime -= 1;
            }//Decrease
            else if(buttontext == "<")
            {
                mSelectedSampleTime += 1;
            }


            if (mSelectedSampleTime < 0)
            {
                mSelectedSampleTime = 0;
            }
            else if (mSelectedSampleTime >= iarrSampleTimes.Length)
            {
                mSelectedSampleTime = iarrSampleTimes.Length-1;
            }


            tboxSampleSpeed.Text = iarrSampleTimes[mSelectedSampleTime] + "";

        }

        private void chartFrequency_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void gboxSignalType_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
