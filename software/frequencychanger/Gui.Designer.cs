using System;
using System.Windows.Forms;

namespace spoolersim
{
  partial class FrequencyChanger
  {
        string version = "0.1";
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.statusLine = new System.Windows.Forms.StatusStrip();
            this.labelStatusLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbarFrequencyMaster = new System.Windows.Forms.TrackBar();
            this.rbuttonModePwm16kHz = new System.Windows.Forms.RadioButton();
            this.rbuttonModeHtl = new System.Windows.Forms.RadioButton();
            this.tboxFrequencyMaster = new System.Windows.Forms.TextBox();
            this.labelMasterFrequency = new System.Windows.Forms.Label();
            this.cboxSerialPort = new System.Windows.Forms.ComboBox();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.buttonSerialPortConnect = new System.Windows.Forms.Button();
            this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
            this.gboxMode = new System.Windows.Forms.GroupBox();
            this.rbuttonModePwm2kHz = new System.Windows.Forms.RadioButton();
            this.rbuttonModePwm4kHz = new System.Windows.Forms.RadioButton();
            this.rbuttonModePwm8kHz = new System.Windows.Forms.RadioButton();
            this.labelFrequencyMin = new System.Windows.Forms.Label();
            this.buttonSetAll = new System.Windows.Forms.Button();
            this.labelFrequencyMax = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLoadChart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage0 = new System.Windows.Forms.TabPage();
            this.cboxSwitchUV = new System.Windows.Forms.CheckBox();
            this.cboxOnTheFly = new System.Windows.Forms.CheckBox();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.gboxW = new System.Windows.Forms.GroupBox();
            this.tbarOffsetW = new System.Windows.Forms.TrackBar();
            this.tbarAmplitudeW = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbuttonStateW2 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateW0 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateW1 = new System.Windows.Forms.RadioButton();
            this.tboxShiftW = new System.Windows.Forms.TextBox();
            this.tboxOffsetW = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbarShiftW = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxAmplitudeW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gBoxV = new System.Windows.Forms.GroupBox();
            this.tbarOffsetV = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbuttonStateV2 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateV0 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateV1 = new System.Windows.Forms.RadioButton();
            this.tbarAmplitudeV = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxAmplitudeV = new System.Windows.Forms.TextBox();
            this.tboxShiftV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxOffsetV = new System.Windows.Forms.TextBox();
            this.tbarShiftV = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxU = new System.Windows.Forms.GroupBox();
            this.tbarOffsetU = new System.Windows.Forms.TrackBar();
            this.tbarAmplitudeU = new System.Windows.Forms.TrackBar();
            this.groupStateU = new System.Windows.Forms.GroupBox();
            this.rbuttonStateU2 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateU0 = new System.Windows.Forms.RadioButton();
            this.rbuttonStateU1 = new System.Windows.Forms.RadioButton();
            this.tboxShiftU = new System.Windows.Forms.TextBox();
            this.tboxOffsetU = new System.Windows.Forms.TextBox();
            this.labelOffsetU = new System.Windows.Forms.Label();
            this.tbarShiftU = new System.Windows.Forms.TrackBar();
            this.labelShiftU = new System.Windows.Forms.Label();
            this.tboxAmplitudeU = new System.Windows.Forms.TextBox();
            this.labeAmplitudeU = new System.Windows.Forms.Label();
            this.chartManual = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cboxRepeatIndefinitely = new System.Windows.Forms.CheckBox();
            this.labelTestFrequency = new System.Windows.Forms.Label();
            this.labelTestTime = new System.Windows.Forms.Label();
            this.labelTimeVariable = new System.Windows.Forms.Label();
            this.labelFrequencyVariable = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHold = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonIncrease = new System.Windows.Forms.Button();
            this.tboxSampleSpeed = new System.Windows.Forms.TextBox();
            this.buttonDecrease = new System.Windows.Forms.Button();
            this.labelSampleSpeed = new System.Windows.Forms.Label();
            this.labelRepeatIndefinitely = new System.Windows.Forms.Label();
            this.chartCurve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbuttonModeStoeber = new System.Windows.Forms.RadioButton();
            this.statusLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFrequencyMaster)).BeginInit();
            this.gboxMode.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage0.SuspendLayout();
            this.gboxW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeW)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftW)).BeginInit();
            this.gBoxV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftV)).BeginInit();
            this.gboxU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeU)).BeginInit();
            this.groupStateU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartManual)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLine
            // 
            this.statusLine.AutoSize = false;
            this.statusLine.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.statusLine.Font = new System.Drawing.Font("SimSun", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLine.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatusLine});
            this.statusLine.Location = new System.Drawing.Point(0, 778);
            this.statusLine.Name = "statusLine";
            this.statusLine.Size = new System.Drawing.Size(1505, 22);
            this.statusLine.TabIndex = 1;
            this.statusLine.Text = "Status initialized ";
            // 
            // labelStatusLine
            // 
            this.labelStatusLine.Name = "labelStatusLine";
            this.labelStatusLine.Size = new System.Drawing.Size(75, 17);
            this.labelStatusLine.Text = "Status Bar";
            // 
            // tbarFrequencyMaster
            // 
            this.tbarFrequencyMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarFrequencyMaster.BackColor = System.Drawing.Color.White;
            this.tbarFrequencyMaster.Location = new System.Drawing.Point(11, 644);
            this.tbarFrequencyMaster.Maximum = 1600;
            this.tbarFrequencyMaster.Name = "tbarFrequencyMaster";
            this.tbarFrequencyMaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarFrequencyMaster.Size = new System.Drawing.Size(1478, 45);
            this.tbarFrequencyMaster.TabIndex = 3;
            this.tbarFrequencyMaster.TickFrequency = 10;
            this.tbarFrequencyMaster.Value = 1;
            this.tbarFrequencyMaster.ValueChanged += new System.EventHandler(this.tbarFrequencyLimiterCallback);
            // 
            // rbuttonModePwm16kHz
            // 
            this.rbuttonModePwm16kHz.AutoSize = true;
            this.rbuttonModePwm16kHz.Location = new System.Drawing.Point(7, 18);
            this.rbuttonModePwm16kHz.Name = "rbuttonModePwm16kHz";
            this.rbuttonModePwm16kHz.Size = new System.Drawing.Size(90, 17);
            this.rbuttonModePwm16kHz.TabIndex = 4;
            this.rbuttonModePwm16kHz.TabStop = true;
            this.rbuttonModePwm16kHz.Text = "PWM(16KHz)";
            this.rbuttonModePwm16kHz.UseVisualStyleBackColor = true;
            this.rbuttonModePwm16kHz.CheckedChanged += new System.EventHandler(this.rbuttonSignalModeCallback);
            // 
            // rbuttonModeHtl
            // 
            this.rbuttonModeHtl.AutoSize = true;
            this.rbuttonModeHtl.Location = new System.Drawing.Point(369, 18);
            this.rbuttonModeHtl.Name = "rbuttonModeHtl";
            this.rbuttonModeHtl.Size = new System.Drawing.Size(46, 17);
            this.rbuttonModeHtl.TabIndex = 5;
            this.rbuttonModeHtl.TabStop = true;
            this.rbuttonModeHtl.Text = "HTL";
            this.rbuttonModeHtl.UseVisualStyleBackColor = true;
            this.rbuttonModeHtl.CheckedChanged += new System.EventHandler(this.rbuttonSignalModeCallback);
            // 
            // tboxFrequencyMaster
            // 
            this.tboxFrequencyMaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tboxFrequencyMaster.Location = new System.Drawing.Point(492, 614);
            this.tboxFrequencyMaster.Name = "tboxFrequencyMaster";
            this.tboxFrequencyMaster.Size = new System.Drawing.Size(62, 29);
            this.tboxFrequencyMaster.TabIndex = 7;
            this.tboxFrequencyMaster.TextChanged += new System.EventHandler(this.tboxFrequencyLimiterCallback);
            // 
            // labelMasterFrequency
            // 
            this.labelMasterFrequency.AutoSize = true;
            this.labelMasterFrequency.Location = new System.Drawing.Point(489, 600);
            this.labelMasterFrequency.Name = "labelMasterFrequency";
            this.labelMasterFrequency.Size = new System.Drawing.Size(114, 13);
            this.labelMasterFrequency.TabIndex = 8;
            this.labelMasterFrequency.Text = "Master Frequency(Hz):";
            // 
            // cboxSerialPort
            // 
            this.cboxSerialPort.FormattingEnabled = true;
            this.cboxSerialPort.Location = new System.Drawing.Point(78, 6);
            this.cboxSerialPort.Name = "cboxSerialPort";
            this.cboxSerialPort.Size = new System.Drawing.Size(80, 21);
            this.cboxSerialPort.TabIndex = 12;
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Location = new System.Drawing.Point(14, 10);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(58, 13);
            this.labelSerialPort.TabIndex = 13;
            this.labelSerialPort.Text = "Serial Port:";
            // 
            // buttonSerialPortConnect
            // 
            this.buttonSerialPortConnect.Location = new System.Drawing.Point(203, 5);
            this.buttonSerialPortConnect.Name = "buttonSerialPortConnect";
            this.buttonSerialPortConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialPortConnect.TabIndex = 14;
            this.buttonSerialPortConnect.Text = "Connect";
            this.buttonSerialPortConnect.UseVisualStyleBackColor = true;
            this.buttonSerialPortConnect.Click += new System.EventHandler(this.buttonSerialPortConnectCallback);
            // 
            // buttonSerialPortRefresh
            // 
            this.buttonSerialPortRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonSerialPortRefresh.Location = new System.Drawing.Point(164, 5);
            this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
            this.buttonSerialPortRefresh.Size = new System.Drawing.Size(33, 23);
            this.buttonSerialPortRefresh.TabIndex = 15;
            this.buttonSerialPortRefresh.Text = "⭯";
            this.buttonSerialPortRefresh.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
            this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefreshCallback);
            // 
            // gboxMode
            // 
            this.gboxMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gboxMode.BackColor = System.Drawing.Color.LemonChiffon;
            this.gboxMode.Controls.Add(this.rbuttonModeStoeber);
            this.gboxMode.Controls.Add(this.rbuttonModePwm2kHz);
            this.gboxMode.Controls.Add(this.rbuttonModePwm4kHz);
            this.gboxMode.Controls.Add(this.rbuttonModePwm8kHz);
            this.gboxMode.Controls.Add(this.rbuttonModeHtl);
            this.gboxMode.Controls.Add(this.rbuttonModePwm16kHz);
            this.gboxMode.Location = new System.Drawing.Point(12, 598);
            this.gboxMode.Name = "gboxMode";
            this.gboxMode.Size = new System.Drawing.Size(471, 45);
            this.gboxMode.TabIndex = 16;
            this.gboxMode.TabStop = false;
            this.gboxMode.Text = "Mode";
            this.gboxMode.Enter += new System.EventHandler(this.gboxSignalType_Enter);
            // 
            // rbuttonModePwm2kHz
            // 
            this.rbuttonModePwm2kHz.AutoSize = true;
            this.rbuttonModePwm2kHz.Location = new System.Drawing.Point(279, 19);
            this.rbuttonModePwm2kHz.Name = "rbuttonModePwm2kHz";
            this.rbuttonModePwm2kHz.Size = new System.Drawing.Size(84, 17);
            this.rbuttonModePwm2kHz.TabIndex = 8;
            this.rbuttonModePwm2kHz.TabStop = true;
            this.rbuttonModePwm2kHz.Text = "PWM(2KHz)";
            this.rbuttonModePwm2kHz.UseVisualStyleBackColor = true;
            // 
            // rbuttonModePwm4kHz
            // 
            this.rbuttonModePwm4kHz.AutoSize = true;
            this.rbuttonModePwm4kHz.Location = new System.Drawing.Point(189, 19);
            this.rbuttonModePwm4kHz.Name = "rbuttonModePwm4kHz";
            this.rbuttonModePwm4kHz.Size = new System.Drawing.Size(84, 17);
            this.rbuttonModePwm4kHz.TabIndex = 7;
            this.rbuttonModePwm4kHz.TabStop = true;
            this.rbuttonModePwm4kHz.Text = "PWM(4KHz)";
            this.rbuttonModePwm4kHz.UseVisualStyleBackColor = true;
            // 
            // rbuttonModePwm8kHz
            // 
            this.rbuttonModePwm8kHz.AutoSize = true;
            this.rbuttonModePwm8kHz.Location = new System.Drawing.Point(103, 19);
            this.rbuttonModePwm8kHz.Name = "rbuttonModePwm8kHz";
            this.rbuttonModePwm8kHz.Size = new System.Drawing.Size(84, 17);
            this.rbuttonModePwm8kHz.TabIndex = 6;
            this.rbuttonModePwm8kHz.TabStop = true;
            this.rbuttonModePwm8kHz.Text = "PWM(8KHz)";
            this.rbuttonModePwm8kHz.UseVisualStyleBackColor = true;
            // 
            // labelFrequencyMin
            // 
            this.labelFrequencyMin.AutoSize = true;
            this.labelFrequencyMin.Location = new System.Drawing.Point(10, 692);
            this.labelFrequencyMin.Name = "labelFrequencyMin";
            this.labelFrequencyMin.Size = new System.Drawing.Size(13, 13);
            this.labelFrequencyMin.TabIndex = 18;
            this.labelFrequencyMin.Text = "0";
            // 
            // buttonSetAll
            // 
            this.buttonSetAll.Location = new System.Drawing.Point(11, 13);
            this.buttonSetAll.Name = "buttonSetAll";
            this.buttonSetAll.Size = new System.Drawing.Size(105, 23);
            this.buttonSetAll.TabIndex = 19;
            this.buttonSetAll.Text = "Apply Settings";
            this.buttonSetAll.UseVisualStyleBackColor = true;
            this.buttonSetAll.Click += new System.EventHandler(this.buttonSetAllCallback);
            // 
            // labelFrequencyMax
            // 
            this.labelFrequencyMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequencyMax.AutoSize = true;
            this.labelFrequencyMax.Location = new System.Drawing.Point(1458, 692);
            this.labelFrequencyMax.Name = "labelFrequencyMax";
            this.labelFrequencyMax.Size = new System.Drawing.Size(31, 13);
            this.labelFrequencyMax.TabIndex = 17;
            this.labelFrequencyMax.Text = "1600";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.buttonSerialPortRefresh);
            this.panel2.Controls.Add(this.cboxSerialPort);
            this.panel2.Controls.Add(this.labelSerialPort);
            this.panel2.Controls.Add(this.buttonSerialPortConnect);
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 33);
            this.panel2.TabIndex = 36;
            // 
            // buttonLoadChart
            // 
            this.buttonLoadChart.Location = new System.Drawing.Point(1405, 10);
            this.buttonLoadChart.Name = "buttonLoadChart";
            this.buttonLoadChart.Size = new System.Drawing.Size(90, 27);
            this.buttonLoadChart.TabIndex = 37;
            this.buttonLoadChart.Text = "Load Data";
            this.buttonLoadChart.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1307, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 38;
            this.button1.Text = "Save Data";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage0);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1505, 732);
            this.tabControl1.TabIndex = 39;
            // 
            // tabPage0
            // 
            this.tabPage0.Controls.Add(this.cboxSwitchUV);
            this.tabPage0.Controls.Add(this.cboxOnTheFly);
            this.tabPage0.Controls.Add(this.buttonGetAll);
            this.tabPage0.Controls.Add(this.gboxW);
            this.tabPage0.Controls.Add(this.gBoxV);
            this.tabPage0.Controls.Add(this.gboxU);
            this.tabPage0.Controls.Add(this.chartManual);
            this.tabPage0.Controls.Add(this.labelFrequencyMax);
            this.tabPage0.Controls.Add(this.labelFrequencyMin);
            this.tabPage0.Controls.Add(this.gboxMode);
            this.tabPage0.Controls.Add(this.buttonSetAll);
            this.tabPage0.Controls.Add(this.tbarFrequencyMaster);
            this.tabPage0.Controls.Add(this.tboxFrequencyMaster);
            this.tabPage0.Controls.Add(this.labelMasterFrequency);
            this.tabPage0.Location = new System.Drawing.Point(4, 22);
            this.tabPage0.Name = "tabPage0";
            this.tabPage0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage0.Size = new System.Drawing.Size(1497, 706);
            this.tabPage0.TabIndex = 1;
            this.tabPage0.Text = "Manual";
            this.tabPage0.UseVisualStyleBackColor = true;
            // 
            // cboxSwitchUV
            // 
            this.cboxSwitchUV.AutoSize = true;
            this.cboxSwitchUV.Location = new System.Drawing.Point(439, 18);
            this.cboxSwitchUV.Name = "cboxSwitchUV";
            this.cboxSwitchUV.Size = new System.Drawing.Size(100, 17);
            this.cboxSwitchUV.TabIndex = 40;
            this.cboxSwitchUV.Text = "Switch U and V";
            this.cboxSwitchUV.UseVisualStyleBackColor = true;
            this.cboxSwitchUV.CheckedChanged += new System.EventHandler(this.cboxOnChangeCallback);
            // 
            // cboxOnTheFly
            // 
            this.cboxOnTheFly.AutoSize = true;
            this.cboxOnTheFly.Location = new System.Drawing.Point(270, 17);
            this.cboxOnTheFly.Name = "cboxOnTheFly";
            this.cboxOnTheFly.Size = new System.Drawing.Size(157, 17);
            this.cboxOnTheFly.TabIndex = 29;
            this.cboxOnTheFly.Text = "Update Settings on Change";
            this.cboxOnTheFly.UseVisualStyleBackColor = true;
            this.cboxOnTheFly.CheckedChanged += new System.EventHandler(this.cboxOnChangeCallback);
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(143, 13);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(111, 23);
            this.buttonGetAll.TabIndex = 28;
            this.buttonGetAll.Text = "Get Settings";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            // 
            // gboxW
            // 
            this.gboxW.BackColor = System.Drawing.Color.PaleTurquoise;
            this.gboxW.Controls.Add(this.tbarOffsetW);
            this.gboxW.Controls.Add(this.tbarAmplitudeW);
            this.gboxW.Controls.Add(this.groupBox2);
            this.gboxW.Controls.Add(this.tboxShiftW);
            this.gboxW.Controls.Add(this.tboxOffsetW);
            this.gboxW.Controls.Add(this.label4);
            this.gboxW.Controls.Add(this.tbarShiftW);
            this.gboxW.Controls.Add(this.label5);
            this.gboxW.Controls.Add(this.tboxAmplitudeW);
            this.gboxW.Controls.Add(this.label6);
            this.gboxW.Location = new System.Drawing.Point(11, 413);
            this.gboxW.Name = "gboxW";
            this.gboxW.Size = new System.Drawing.Size(528, 181);
            this.gboxW.TabIndex = 27;
            this.gboxW.TabStop = false;
            this.gboxW.Text = "W";
            // 
            // tbarOffsetW
            // 
            this.tbarOffsetW.Location = new System.Drawing.Point(98, 126);
            this.tbarOffsetW.Maximum = 50;
            this.tbarOffsetW.Name = "tbarOffsetW";
            this.tbarOffsetW.Size = new System.Drawing.Size(358, 45);
            this.tbarOffsetW.TabIndex = 48;
            this.tbarOffsetW.Value = 1;
            this.tbarOffsetW.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // tbarAmplitudeW
            // 
            this.tbarAmplitudeW.Location = new System.Drawing.Point(98, 83);
            this.tbarAmplitudeW.Maximum = 100;
            this.tbarAmplitudeW.Name = "tbarAmplitudeW";
            this.tbarAmplitudeW.Size = new System.Drawing.Size(358, 45);
            this.tbarAmplitudeW.TabIndex = 47;
            this.tbarAmplitudeW.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbuttonStateW2);
            this.groupBox2.Controls.Add(this.rbuttonStateW0);
            this.groupBox2.Controls.Add(this.rbuttonStateW1);
            this.groupBox2.Location = new System.Drawing.Point(7, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 80);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "State";
            // 
            // rbuttonStateW2
            // 
            this.rbuttonStateW2.AutoSize = true;
            this.rbuttonStateW2.Location = new System.Drawing.Point(8, 42);
            this.rbuttonStateW2.Name = "rbuttonStateW2";
            this.rbuttonStateW2.Size = new System.Drawing.Size(75, 17);
            this.rbuttonStateW2.TabIndex = 2;
            this.rbuttonStateW2.TabStop = true;
            this.rbuttonStateW2.Text = "Frequency";
            this.rbuttonStateW2.UseVisualStyleBackColor = true;
            this.rbuttonStateW2.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateW0
            // 
            this.rbuttonStateW0.AutoSize = true;
            this.rbuttonStateW0.Location = new System.Drawing.Point(46, 19);
            this.rbuttonStateW0.Name = "rbuttonStateW0";
            this.rbuttonStateW0.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateW0.TabIndex = 1;
            this.rbuttonStateW0.TabStop = true;
            this.rbuttonStateW0.Text = "Off";
            this.rbuttonStateW0.UseVisualStyleBackColor = true;
            this.rbuttonStateW0.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateW1
            // 
            this.rbuttonStateW1.AutoSize = true;
            this.rbuttonStateW1.Location = new System.Drawing.Point(8, 19);
            this.rbuttonStateW1.Name = "rbuttonStateW1";
            this.rbuttonStateW1.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateW1.TabIndex = 0;
            this.rbuttonStateW1.TabStop = true;
            this.rbuttonStateW1.Text = "On";
            this.rbuttonStateW1.UseVisualStyleBackColor = true;
            this.rbuttonStateW1.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // tboxShiftW
            // 
            this.tboxShiftW.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tboxShiftW.Location = new System.Drawing.Point(465, 23);
            this.tboxShiftW.Name = "tboxShiftW";
            this.tboxShiftW.Size = new System.Drawing.Size(57, 29);
            this.tboxShiftW.TabIndex = 45;
            this.tboxShiftW.TextChanged += new System.EventHandler(this.tboxShiftLimiterCallback);
            // 
            // tboxOffsetW
            // 
            this.tboxOffsetW.Location = new System.Drawing.Point(477, 126);
            this.tboxOffsetW.Name = "tboxOffsetW";
            this.tboxOffsetW.Size = new System.Drawing.Size(34, 20);
            this.tboxOffsetW.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Offset (%):";
            // 
            // tbarShiftW
            // 
            this.tbarShiftW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarShiftW.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbarShiftW.Location = new System.Drawing.Point(6, 25);
            this.tbarShiftW.Maximum = 360;
            this.tbarShiftW.Name = "tbarShiftW";
            this.tbarShiftW.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarShiftW.Size = new System.Drawing.Size(455, 45);
            this.tbarShiftW.TabIndex = 42;
            this.tbarShiftW.TickFrequency = 10;
            this.tbarShiftW.Value = 1;
            this.tbarShiftW.ValueChanged += new System.EventHandler(this.tbarShiftLimiterCallback);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Shift(°):";
            // 
            // tboxAmplitudeW
            // 
            this.tboxAmplitudeW.Location = new System.Drawing.Point(477, 82);
            this.tboxAmplitudeW.Name = "tboxAmplitudeW";
            this.tboxAmplitudeW.Size = new System.Drawing.Size(34, 20);
            this.tboxAmplitudeW.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Amplitude(%):";
            // 
            // gBoxV
            // 
            this.gBoxV.BackColor = System.Drawing.Color.Khaki;
            this.gBoxV.Controls.Add(this.tbarOffsetV);
            this.gBoxV.Controls.Add(this.groupBox1);
            this.gBoxV.Controls.Add(this.tbarAmplitudeV);
            this.gBoxV.Controls.Add(this.label3);
            this.gBoxV.Controls.Add(this.tboxAmplitudeV);
            this.gBoxV.Controls.Add(this.tboxShiftV);
            this.gBoxV.Controls.Add(this.label2);
            this.gBoxV.Controls.Add(this.tboxOffsetV);
            this.gBoxV.Controls.Add(this.tbarShiftV);
            this.gBoxV.Controls.Add(this.label1);
            this.gBoxV.Location = new System.Drawing.Point(11, 226);
            this.gBoxV.Name = "gBoxV";
            this.gBoxV.Size = new System.Drawing.Size(528, 181);
            this.gBoxV.TabIndex = 26;
            this.gBoxV.TabStop = false;
            this.gBoxV.Text = "V";
            // 
            // tbarOffsetV
            // 
            this.tbarOffsetV.Location = new System.Drawing.Point(98, 124);
            this.tbarOffsetV.Maximum = 50;
            this.tbarOffsetV.Name = "tbarOffsetV";
            this.tbarOffsetV.Size = new System.Drawing.Size(358, 45);
            this.tbarOffsetV.TabIndex = 48;
            this.tbarOffsetV.Value = 1;
            this.tbarOffsetV.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbuttonStateV2);
            this.groupBox1.Controls.Add(this.rbuttonStateV0);
            this.groupBox1.Controls.Add(this.rbuttonStateV1);
            this.groupBox1.Location = new System.Drawing.Point(7, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 71);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // rbuttonStateV2
            // 
            this.rbuttonStateV2.AutoSize = true;
            this.rbuttonStateV2.Location = new System.Drawing.Point(8, 42);
            this.rbuttonStateV2.Name = "rbuttonStateV2";
            this.rbuttonStateV2.Size = new System.Drawing.Size(75, 17);
            this.rbuttonStateV2.TabIndex = 2;
            this.rbuttonStateV2.TabStop = true;
            this.rbuttonStateV2.Text = "Frequency";
            this.rbuttonStateV2.UseVisualStyleBackColor = true;
            this.rbuttonStateV2.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateV0
            // 
            this.rbuttonStateV0.AutoSize = true;
            this.rbuttonStateV0.Location = new System.Drawing.Point(46, 19);
            this.rbuttonStateV0.Name = "rbuttonStateV0";
            this.rbuttonStateV0.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateV0.TabIndex = 1;
            this.rbuttonStateV0.TabStop = true;
            this.rbuttonStateV0.Text = "Off";
            this.rbuttonStateV0.UseVisualStyleBackColor = true;
            this.rbuttonStateV0.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateV1
            // 
            this.rbuttonStateV1.AutoSize = true;
            this.rbuttonStateV1.Location = new System.Drawing.Point(8, 19);
            this.rbuttonStateV1.Name = "rbuttonStateV1";
            this.rbuttonStateV1.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateV1.TabIndex = 0;
            this.rbuttonStateV1.TabStop = true;
            this.rbuttonStateV1.Text = "On";
            this.rbuttonStateV1.UseVisualStyleBackColor = true;
            this.rbuttonStateV1.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // tbarAmplitudeV
            // 
            this.tbarAmplitudeV.Location = new System.Drawing.Point(98, 81);
            this.tbarAmplitudeV.Maximum = 100;
            this.tbarAmplitudeV.Name = "tbarAmplitudeV";
            this.tbarAmplitudeV.Size = new System.Drawing.Size(358, 45);
            this.tbarAmplitudeV.TabIndex = 47;
            this.tbarAmplitudeV.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Amplitude(%):";
            // 
            // tboxAmplitudeV
            // 
            this.tboxAmplitudeV.Location = new System.Drawing.Point(477, 80);
            this.tboxAmplitudeV.Name = "tboxAmplitudeV";
            this.tboxAmplitudeV.Size = new System.Drawing.Size(34, 20);
            this.tboxAmplitudeV.TabIndex = 39;
            // 
            // tboxShiftV
            // 
            this.tboxShiftV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tboxShiftV.Location = new System.Drawing.Point(465, 21);
            this.tboxShiftV.Name = "tboxShiftV";
            this.tboxShiftV.Size = new System.Drawing.Size(57, 29);
            this.tboxShiftV.TabIndex = 45;
            this.tboxShiftV.TextChanged += new System.EventHandler(this.tboxShiftLimiterCallback);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Shift(°):";
            // 
            // tboxOffsetV
            // 
            this.tboxOffsetV.Location = new System.Drawing.Point(477, 124);
            this.tboxOffsetV.Name = "tboxOffsetV";
            this.tboxOffsetV.Size = new System.Drawing.Size(34, 20);
            this.tboxOffsetV.TabIndex = 44;
            // 
            // tbarShiftV
            // 
            this.tbarShiftV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarShiftV.BackColor = System.Drawing.Color.Khaki;
            this.tbarShiftV.Location = new System.Drawing.Point(6, 23);
            this.tbarShiftV.Maximum = 360;
            this.tbarShiftV.Name = "tbarShiftV";
            this.tbarShiftV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarShiftV.Size = new System.Drawing.Size(455, 45);
            this.tbarShiftV.TabIndex = 42;
            this.tbarShiftV.TickFrequency = 10;
            this.tbarShiftV.Value = 1;
            this.tbarShiftV.ValueChanged += new System.EventHandler(this.tbarShiftLimiterCallback);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Offset (%):";
            // 
            // gboxU
            // 
            this.gboxU.BackColor = System.Drawing.Color.LightCoral;
            this.gboxU.Controls.Add(this.tbarOffsetU);
            this.gboxU.Controls.Add(this.tbarAmplitudeU);
            this.gboxU.Controls.Add(this.groupStateU);
            this.gboxU.Controls.Add(this.tboxShiftU);
            this.gboxU.Controls.Add(this.tboxOffsetU);
            this.gboxU.Controls.Add(this.labelOffsetU);
            this.gboxU.Controls.Add(this.tbarShiftU);
            this.gboxU.Controls.Add(this.labelShiftU);
            this.gboxU.Controls.Add(this.tboxAmplitudeU);
            this.gboxU.Controls.Add(this.labeAmplitudeU);
            this.gboxU.Location = new System.Drawing.Point(11, 41);
            this.gboxU.Name = "gboxU";
            this.gboxU.Size = new System.Drawing.Size(528, 181);
            this.gboxU.TabIndex = 25;
            this.gboxU.TabStop = false;
            this.gboxU.Text = "U";
            // 
            // tbarOffsetU
            // 
            this.tbarOffsetU.Location = new System.Drawing.Point(98, 132);
            this.tbarOffsetU.Maximum = 50;
            this.tbarOffsetU.Name = "tbarOffsetU";
            this.tbarOffsetU.Size = new System.Drawing.Size(358, 45);
            this.tbarOffsetU.TabIndex = 38;
            this.tbarOffsetU.Value = 1;
            this.tbarOffsetU.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // tbarAmplitudeU
            // 
            this.tbarAmplitudeU.Location = new System.Drawing.Point(98, 89);
            this.tbarAmplitudeU.Maximum = 100;
            this.tbarAmplitudeU.Name = "tbarAmplitudeU";
            this.tbarAmplitudeU.Size = new System.Drawing.Size(358, 45);
            this.tbarAmplitudeU.TabIndex = 37;
            this.tbarAmplitudeU.ValueChanged += new System.EventHandler(this.tbarAmpOffsetLimiterCallback);
            // 
            // groupStateU
            // 
            this.groupStateU.Controls.Add(this.rbuttonStateU2);
            this.groupStateU.Controls.Add(this.rbuttonStateU0);
            this.groupStateU.Controls.Add(this.rbuttonStateU1);
            this.groupStateU.Location = new System.Drawing.Point(7, 103);
            this.groupStateU.Name = "groupStateU";
            this.groupStateU.Size = new System.Drawing.Size(86, 70);
            this.groupStateU.TabIndex = 36;
            this.groupStateU.TabStop = false;
            this.groupStateU.Text = "State";
            // 
            // rbuttonStateU2
            // 
            this.rbuttonStateU2.AutoSize = true;
            this.rbuttonStateU2.Location = new System.Drawing.Point(6, 42);
            this.rbuttonStateU2.Name = "rbuttonStateU2";
            this.rbuttonStateU2.Size = new System.Drawing.Size(75, 17);
            this.rbuttonStateU2.TabIndex = 2;
            this.rbuttonStateU2.TabStop = true;
            this.rbuttonStateU2.Text = "Frequency";
            this.rbuttonStateU2.UseVisualStyleBackColor = true;
            this.rbuttonStateU2.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateU0
            // 
            this.rbuttonStateU0.AutoSize = true;
            this.rbuttonStateU0.Location = new System.Drawing.Point(46, 19);
            this.rbuttonStateU0.Name = "rbuttonStateU0";
            this.rbuttonStateU0.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateU0.TabIndex = 1;
            this.rbuttonStateU0.TabStop = true;
            this.rbuttonStateU0.Text = "Off";
            this.rbuttonStateU0.UseVisualStyleBackColor = true;
            this.rbuttonStateU0.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // rbuttonStateU1
            // 
            this.rbuttonStateU1.AutoSize = true;
            this.rbuttonStateU1.Location = new System.Drawing.Point(6, 19);
            this.rbuttonStateU1.Name = "rbuttonStateU1";
            this.rbuttonStateU1.Size = new System.Drawing.Size(39, 17);
            this.rbuttonStateU1.TabIndex = 0;
            this.rbuttonStateU1.TabStop = true;
            this.rbuttonStateU1.Text = "On";
            this.rbuttonStateU1.UseVisualStyleBackColor = true;
            this.rbuttonStateU1.CheckedChanged += new System.EventHandler(this.rbuttonStateChangedCallback);
            // 
            // tboxShiftU
            // 
            this.tboxShiftU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.tboxShiftU.Location = new System.Drawing.Point(465, 29);
            this.tboxShiftU.Name = "tboxShiftU";
            this.tboxShiftU.Size = new System.Drawing.Size(57, 29);
            this.tboxShiftU.TabIndex = 35;
            this.tboxShiftU.TextChanged += new System.EventHandler(this.tboxShiftLimiterCallback);
            // 
            // tboxOffsetU
            // 
            this.tboxOffsetU.Location = new System.Drawing.Point(477, 132);
            this.tboxOffsetU.Name = "tboxOffsetU";
            this.tboxOffsetU.Size = new System.Drawing.Size(34, 20);
            this.tboxOffsetU.TabIndex = 30;
            // 
            // labelOffsetU
            // 
            this.labelOffsetU.AutoSize = true;
            this.labelOffsetU.Location = new System.Drawing.Point(462, 116);
            this.labelOffsetU.Name = "labelOffsetU";
            this.labelOffsetU.Size = new System.Drawing.Size(55, 13);
            this.labelOffsetU.TabIndex = 29;
            this.labelOffsetU.Text = "Offset (%):";
            // 
            // tbarShiftU
            // 
            this.tbarShiftU.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarShiftU.BackColor = System.Drawing.Color.LightCoral;
            this.tbarShiftU.Location = new System.Drawing.Point(6, 31);
            this.tbarShiftU.Maximum = 360;
            this.tbarShiftU.Name = "tbarShiftU";
            this.tbarShiftU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbarShiftU.Size = new System.Drawing.Size(455, 45);
            this.tbarShiftU.TabIndex = 27;
            this.tbarShiftU.TickFrequency = 10;
            this.tbarShiftU.Value = 1;
            this.tbarShiftU.ValueChanged += new System.EventHandler(this.tbarShiftLimiterCallback);
            // 
            // labelShiftU
            // 
            this.labelShiftU.AutoSize = true;
            this.labelShiftU.Location = new System.Drawing.Point(462, 10);
            this.labelShiftU.Name = "labelShiftU";
            this.labelShiftU.Size = new System.Drawing.Size(41, 13);
            this.labelShiftU.TabIndex = 26;
            this.labelShiftU.Text = "Shift(°):";
            // 
            // tboxAmplitudeU
            // 
            this.tboxAmplitudeU.Location = new System.Drawing.Point(477, 88);
            this.tboxAmplitudeU.Name = "tboxAmplitudeU";
            this.tboxAmplitudeU.Size = new System.Drawing.Size(34, 20);
            this.tboxAmplitudeU.TabIndex = 23;
            this.tboxAmplitudeU.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labeAmplitudeU
            // 
            this.labeAmplitudeU.AutoSize = true;
            this.labeAmplitudeU.Location = new System.Drawing.Point(452, 73);
            this.labeAmplitudeU.Name = "labeAmplitudeU";
            this.labeAmplitudeU.Size = new System.Drawing.Size(70, 13);
            this.labeAmplitudeU.TabIndex = 24;
            this.labeAmplitudeU.Text = "Amplitude(%):";
            // 
            // chartManual
            // 
            chartArea1.Name = "chartArea";
            this.chartManual.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartManual.Legends.Add(legend1);
            this.chartManual.Location = new System.Drawing.Point(523, 11);
            this.chartManual.Name = "chartManual";
            series1.BorderWidth = 4;
            series1.ChartArea = "chartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "U";
            series2.BorderWidth = 4;
            series2.ChartArea = "chartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Khaki;
            series2.Legend = "Legend1";
            series2.Name = "V";
            series3.BorderWidth = 4;
            series3.ChartArea = "chartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.PaleTurquoise;
            series3.Legend = "Legend1";
            series3.Name = "W";
            this.chartManual.Series.Add(series1);
            this.chartManual.Series.Add(series2);
            this.chartManual.Series.Add(series3);
            this.chartManual.Size = new System.Drawing.Size(966, 583);
            this.chartManual.TabIndex = 20;
            this.chartManual.Text = "signalChart";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cboxRepeatIndefinitely);
            this.tabPage1.Controls.Add(this.labelTestFrequency);
            this.tabPage1.Controls.Add(this.labelTestTime);
            this.tabPage1.Controls.Add(this.labelTimeVariable);
            this.tabPage1.Controls.Add(this.labelFrequencyVariable);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Controls.Add(this.buttonHold);
            this.tabPage1.Controls.Add(this.buttonStop);
            this.tabPage1.Controls.Add(this.buttonIncrease);
            this.tabPage1.Controls.Add(this.tboxSampleSpeed);
            this.tabPage1.Controls.Add(this.buttonDecrease);
            this.tabPage1.Controls.Add(this.labelSampleSpeed);
            this.tabPage1.Controls.Add(this.labelRepeatIndefinitely);
            this.tabPage1.Controls.Add(this.chartCurve);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1497, 706);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Curve";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboxRepeatIndefinitely
            // 
            this.cboxRepeatIndefinitely.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxRepeatIndefinitely.BackColor = System.Drawing.Color.Beige;
            this.cboxRepeatIndefinitely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRepeatIndefinitely.Location = new System.Drawing.Point(1386, 61);
            this.cboxRepeatIndefinitely.Name = "cboxRepeatIndefinitely";
            this.cboxRepeatIndefinitely.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboxRepeatIndefinitely.Size = new System.Drawing.Size(19, 19);
            this.cboxRepeatIndefinitely.TabIndex = 25;
            this.cboxRepeatIndefinitely.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cboxRepeatIndefinitely.UseVisualStyleBackColor = false;
            // 
            // labelTestFrequency
            // 
            this.labelTestFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTestFrequency.AutoSize = true;
            this.labelTestFrequency.BackColor = System.Drawing.Color.Beige;
            this.labelTestFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestFrequency.Location = new System.Drawing.Point(1264, 611);
            this.labelTestFrequency.Name = "labelTestFrequency";
            this.labelTestFrequency.Size = new System.Drawing.Size(67, 15);
            this.labelTestFrequency.TabIndex = 32;
            this.labelTestFrequency.Text = "Frequency:";
            // 
            // labelTestTime
            // 
            this.labelTestTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTestTime.AutoSize = true;
            this.labelTestTime.BackColor = System.Drawing.Color.Beige;
            this.labelTestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTestTime.Location = new System.Drawing.Point(1293, 586);
            this.labelTestTime.Name = "labelTestTime";
            this.labelTestTime.Size = new System.Drawing.Size(38, 15);
            this.labelTestTime.TabIndex = 31;
            this.labelTestTime.Text = "Time:";
            // 
            // labelTimeVariable
            // 
            this.labelTimeVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeVariable.AutoSize = true;
            this.labelTimeVariable.BackColor = System.Drawing.Color.Beige;
            this.labelTimeVariable.Location = new System.Drawing.Point(1355, 588);
            this.labelTimeVariable.Name = "labelTimeVariable";
            this.labelTimeVariable.Size = new System.Drawing.Size(93, 13);
            this.labelTimeVariable.TabIndex = 33;
            this.labelTimeVariable.Text = "labelTimerVariable";
            // 
            // labelFrequencyVariable
            // 
            this.labelFrequencyVariable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFrequencyVariable.AutoSize = true;
            this.labelFrequencyVariable.BackColor = System.Drawing.Color.Beige;
            this.labelFrequencyVariable.Location = new System.Drawing.Point(1355, 613);
            this.labelFrequencyVariable.Name = "labelFrequencyVariable";
            this.labelFrequencyVariable.Size = new System.Drawing.Size(117, 13);
            this.labelFrequencyVariable.TabIndex = 34;
            this.labelFrequencyVariable.Text = "labelFrequencyVariable";
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonStart.Location = new System.Drawing.Point(1420, 672);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(71, 23);
            this.buttonStart.TabIndex = 22;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartCallback);
            // 
            // buttonHold
            // 
            this.buttonHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.buttonHold.Location = new System.Drawing.Point(1344, 673);
            this.buttonHold.Name = "buttonHold";
            this.buttonHold.Size = new System.Drawing.Size(71, 23);
            this.buttonHold.TabIndex = 27;
            this.buttonHold.Text = "Hold";
            this.buttonHold.UseVisualStyleBackColor = false;
            this.buttonHold.Click += new System.EventHandler(this.buttonStartCallback);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonStop.Location = new System.Drawing.Point(1266, 673);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(71, 23);
            this.buttonStop.TabIndex = 26;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStartCallback);
            // 
            // buttonIncrease
            // 
            this.buttonIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIncrease.Location = new System.Drawing.Point(1447, 98);
            this.buttonIncrease.Name = "buttonIncrease";
            this.buttonIncrease.Size = new System.Drawing.Size(21, 23);
            this.buttonIncrease.TabIndex = 28;
            this.buttonIncrease.Text = ">";
            this.buttonIncrease.UseVisualStyleBackColor = true;
            this.buttonIncrease.Click += new System.EventHandler(this.sampleFrequencyCallback);
            // 
            // tboxSampleSpeed
            // 
            this.tboxSampleSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSampleSpeed.Location = new System.Drawing.Point(1411, 99);
            this.tboxSampleSpeed.Name = "tboxSampleSpeed";
            this.tboxSampleSpeed.ReadOnly = true;
            this.tboxSampleSpeed.Size = new System.Drawing.Size(30, 20);
            this.tboxSampleSpeed.TabIndex = 23;
            this.tboxSampleSpeed.Text = "1000";
            this.tboxSampleSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDecrease
            // 
            this.buttonDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDecrease.Location = new System.Drawing.Point(1385, 97);
            this.buttonDecrease.Name = "buttonDecrease";
            this.buttonDecrease.Size = new System.Drawing.Size(20, 23);
            this.buttonDecrease.TabIndex = 29;
            this.buttonDecrease.Text = "<";
            this.buttonDecrease.UseVisualStyleBackColor = true;
            this.buttonDecrease.Click += new System.EventHandler(this.sampleFrequencyCallback);
            // 
            // labelSampleSpeed
            // 
            this.labelSampleSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSampleSpeed.AutoSize = true;
            this.labelSampleSpeed.BackColor = System.Drawing.Color.Beige;
            this.labelSampleSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSampleSpeed.Location = new System.Drawing.Point(1264, 96);
            this.labelSampleSpeed.Name = "labelSampleSpeed";
            this.labelSampleSpeed.Size = new System.Drawing.Size(115, 15);
            this.labelSampleSpeed.TabIndex = 24;
            this.labelSampleSpeed.Text = "Sample speed(ms):";
            // 
            // labelRepeatIndefinitely
            // 
            this.labelRepeatIndefinitely.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRepeatIndefinitely.AutoSize = true;
            this.labelRepeatIndefinitely.BackColor = System.Drawing.Color.Beige;
            this.labelRepeatIndefinitely.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepeatIndefinitely.Location = new System.Drawing.Point(1264, 61);
            this.labelRepeatIndefinitely.Name = "labelRepeatIndefinitely";
            this.labelRepeatIndefinitely.Size = new System.Drawing.Size(111, 15);
            this.labelRepeatIndefinitely.TabIndex = 30;
            this.labelRepeatIndefinitely.Text = "Repeat Indefinitely:";
            // 
            // chartCurve
            // 
            this.chartCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartCurve.BackColor = System.Drawing.Color.Beige;
            this.chartCurve.BorderlineColor = System.Drawing.Color.Black;
            this.chartCurve.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartCurve.BorderlineWidth = 3;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.Title = "Time in s";
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.Title = "Frequency in 1/s";
            chartArea2.BackColor = System.Drawing.SystemColors.ButtonFace;
            chartArea2.Name = "ChartArea1";
            this.chartCurve.ChartAreas.Add(chartArea2);
            this.chartCurve.ImeMode = System.Windows.Forms.ImeMode.Off;
            legend2.BackColor = System.Drawing.Color.LemonChiffon;
            legend2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            legend2.Name = "Frequency";
            legend2.TitleAlignment = System.Drawing.StringAlignment.Near;
            legend2.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.chartCurve.Legends.Add(legend2);
            this.chartCurve.Location = new System.Drawing.Point(0, 0);
            this.chartCurve.Name = "chartCurve";
            this.chartCurve.Size = new System.Drawing.Size(1497, 703);
            this.chartCurve.TabIndex = 0;
            this.chartCurve.Text = "chartFrequencyPlot";
            this.chartCurve.Click += new System.EventHandler(this.chartFrequency_Click);
            this.chartCurve.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chartFrequencyMouseDownCallback);
            this.chartCurve.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chartFrequencyMouseMoveCallback);
            this.chartCurve.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chartFrequencyMouseUpCallback);
            this.chartCurve.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chartFrequencyMouseWheelCallback);
            // 
            // rbuttonModeStoeber
            // 
            this.rbuttonModeStoeber.AutoSize = true;
            this.rbuttonModeStoeber.Location = new System.Drawing.Point(415, 18);
            this.rbuttonModeStoeber.Name = "rbuttonModeStoeber";
            this.rbuttonModeStoeber.Size = new System.Drawing.Size(56, 17);
            this.rbuttonModeStoeber.TabIndex = 9;
            this.rbuttonModeStoeber.TabStop = true;
            this.rbuttonModeStoeber.Text = "Stöber";
            this.rbuttonModeStoeber.UseVisualStyleBackColor = true;
            // 
            // FrequencyChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1505, 800);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLoadChart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusLine);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "FrequencyChanger";
            this.Text = "Frequency Changer Version: 06.10.2021";
            this.Load += new System.EventHandler(this.formManualoadCallback);
            this.statusLine.ResumeLayout(false);
            this.statusLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarFrequencyMaster)).EndInit();
            this.gboxMode.ResumeLayout(false);
            this.gboxMode.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage0.ResumeLayout(false);
            this.tabPage0.PerformLayout();
            this.gboxW.ResumeLayout(false);
            this.gboxW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeW)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftW)).EndInit();
            this.gBoxV.ResumeLayout(false);
            this.gBoxV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftV)).EndInit();
            this.gboxU.ResumeLayout(false);
            this.gboxU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOffsetU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarAmplitudeU)).EndInit();
            this.groupStateU.ResumeLayout(false);
            this.groupStateU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarShiftU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartManual)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


        #endregion


    private System.Windows.Forms.StatusStrip statusLine;
        private System.Windows.Forms.TrackBar tbarFrequencyMaster;

        private System.Windows.Forms.RadioButton rbuttonModeHtl;
        private System.Windows.Forms.TextBox tboxFrequencyMaster;
        private System.Windows.Forms.Label labelMasterFrequency;
        private System.Windows.Forms.ComboBox cboxSerialPort;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.Button buttonSerialPortConnect;
        private System.Windows.Forms.Button buttonSerialPortRefresh;
        private System.Windows.Forms.GroupBox gboxMode;
        private ToolStripStatusLabel labelStatusLine;
        private Label labelFrequencyMin;
        private Button buttonSetAll;
        private Label labelFrequencyMax;
        private Panel panel2;
        private Button buttonLoadChart;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage0;
        private TabPage tabPage1;
        private CheckBox cboxRepeatIndefinitely;
        private Label labelTestFrequency;
        private Label labelTestTime;
        private Label labelTimeVariable;
        private Label labelFrequencyVariable;
        private Button buttonStart;
        private Button buttonHold;
        private Button buttonStop;
        private Button buttonIncrease;
        private TextBox tboxSampleSpeed;
        private Button buttonDecrease;
        private Label labelSampleSpeed;
        private Label labelRepeatIndefinitely;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCurve;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartManual;
        private TextBox tboxAmplitudeU;
        private Label labeAmplitudeU;
        private GroupBox gboxU;
        private GroupBox gboxW;
        private GroupBox gBoxV;
        private TextBox tboxOffsetU;
        private Label labelOffsetU;
        private TrackBar tbarShiftU;
        private Label labelShiftU;
        private TextBox tboxShiftU;
        private Button buttonGetAll;
        private CheckBox cboxOnTheFly;
        private GroupBox groupStateU;
        private RadioButton rbuttonStateU2;
        private RadioButton rbuttonStateU0;
        private RadioButton rbuttonStateU1;
        private TrackBar tbarOffsetW;
        private TrackBar tbarAmplitudeW;
        private GroupBox groupBox2;
        private RadioButton rbuttonStateW2;
        private RadioButton rbuttonStateW0;
        private RadioButton rbuttonStateW1;
        private TextBox tboxShiftW;
        private TextBox tboxOffsetW;
        private Label label4;
        private TrackBar tbarShiftW;
        private Label label5;
        private TextBox tboxAmplitudeW;
        private Label label6;
        private TrackBar tbarOffsetV;
        private GroupBox groupBox1;
        private RadioButton rbuttonStateV2;
        private RadioButton rbuttonStateV0;
        private RadioButton rbuttonStateV1;
        private TrackBar tbarAmplitudeV;
        private Label label3;
        private TextBox tboxAmplitudeV;
        private TextBox tboxShiftV;
        private Label label2;
        private TextBox tboxOffsetV;
        private TrackBar tbarShiftV;
        private Label label1;
        private TrackBar tbarOffsetU;
        private TrackBar tbarAmplitudeU;
        private CheckBox cboxSwitchUV;
        private RadioButton rbuttonModePwm8kHz;
        private RadioButton rbuttonModePwm4kHz;
        private RadioButton rbuttonModePwm16kHz;
        private RadioButton rbuttonModePwm2kHz;
        private RadioButton rbuttonModeStoeber;
    }
}

