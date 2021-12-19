using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace frequencychanger
{
    class Communication
    {

        static SerialPort mSerialPort;

        public Boolean mSerialPortOpen;
        public byte[] mReceiveBuffer;
        public int mError;
        public void OpenPort(string portName)
        {
          
            try
            {
                // Create a new SerialPort object with default settings.
                mSerialPort = new SerialPort();

                // Allow the user to set the appropriate properties.
                mSerialPort.PortName = portName;
                mSerialPort.BaudRate = 115200;
                mSerialPort.Parity = Parity.None;
                mSerialPort.DataBits = 8;
                mSerialPort.StopBits = StopBits.One;
                mSerialPort.Handshake = Handshake.None;

                // Set the read/write timeouts
                mSerialPort.ReadTimeout = (int)TimeSpan.FromSeconds(2.5).TotalMilliseconds;    // Infinite Timeout
                mSerialPort.WriteTimeout = (int)TimeSpan.FromSeconds(2.5).TotalMilliseconds;

                mSerialPort.Open();
                mSerialPortOpen = true;

                mReceiveBuffer = new byte[64];
            }
            catch (Exception e)
            {
                mSerialPortOpen = false;
            }
        }
        public string[] GetPortNames(){
            return SerialPort.GetPortNames();
        }

        public void ClosePort()
        {
            try
            {
                mSerialPort.Close();
            }
            catch (Exception e)
            {
            }
            mSerialPortOpen = false;
        }

        public async Task<int> SetFrequencies(int freqMaster, int stateU, int stateV, int stateW) {
            int length = (3 + 4 + 3);
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)9;
            packet[2] = (byte)0;

            packet[3] = (byte)(freqMaster);
            packet[4] = (byte)(freqMaster >> 8);
            packet[5] = (byte)(freqMaster >> 16);
            packet[6] = (byte)(freqMaster >> 24);

            packet[7] = (byte)(stateU);
            packet[8] = (byte)(stateV);
            packet[9] = (byte)(stateW);
    

            return this.Communicate(5, packet);
        }

        public async Task<int> SetOffsetsAndAmplitudes(int amptU, int ampV, int ampW, int offU, int offV, int offW)
        {
            int length = (3 + 2 * 3 * 2);
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)10;
            packet[2] = (byte)0;

            packet[3] = (byte)(amptU);
            packet[4] = (byte)(amptU >> 8);
            packet[5] = (byte)(ampV);
            packet[6] = (byte)(ampV >> 8);
            packet[7] = (byte)(ampW);
            packet[8] = (byte)(ampW >> 8);

            packet[9] = (byte)(offU);
            packet[10] = (byte)(offU >> 8);
            packet[11] = (byte)(offV);
            packet[12] = (byte)(offV >> 8);
            packet[13] = (byte)(offW);
            packet[14] = (byte)(offW >> 8);

            return this.Communicate(5, packet);
        }

        public async Task<int> SetShifts(int shiftU, int shiftV, int shiftW)
        {
            int length = (3 + 2 * 3);
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)11;
            packet[2] = (byte)0;
            packet[3] = (byte)(shiftU);
            packet[4] = (byte)(shiftU >> 8);
            packet[5] = (byte)(shiftV);
            packet[6] = (byte)(shiftV >> 8);
            packet[7] = (byte)(shiftW);
            packet[8] = (byte)(shiftW >> 8);



            return this.Communicate(5, packet);
        }


        public async Task<int> SetMode(int mode)
        {
            int length = (4);
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)32;
            packet[2] = (byte)0;
            packet[3] = (byte)(mode);
            return this.Communicate(5, packet);
        }


        public async Task<int> GetAll() {
            int length = 3;
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)49;
            packet[2] = (byte)0;
            
            return this.Communicate(((3 * 4 * 4) + 4 + 1), packet);
        }



        public async Task<int> SetAll(int freqMaster, int stateU, int stateV, int stateW, int shiftU, int shiftV, int shiftW, int ampU, int ampV, int ampW, int offU, int offV, int offW, int mode)
        {
            int length = (3 + 1 + 4 + 3+ 3*6);
            byte[] packet = new byte[length];
            packet[0] = (byte)length;
            packet[1] = (byte)48;
            packet[2] = (byte)0;
            packet[3] = (byte)(mode);

            packet[4] = (byte)(freqMaster);
            packet[5] = (byte)(freqMaster >> 8);
            packet[6] = (byte)(freqMaster >> 16);
            packet[7] = (byte)(freqMaster >> 24);

            packet[8] = (byte)(stateU);
            packet[9] = (byte)(stateV );
            packet[10] = (byte)(stateW);
            
            packet[11] = (byte)(shiftU);
            packet[12] = (byte)(shiftU >> 8);
            packet[13] = (byte)(shiftV);
            packet[14] = (byte)(shiftV >> 8);
            packet[15] = (byte)(shiftW);
            packet[16] = (byte)(shiftW >> 8);

            packet[17] = (byte)(ampU);
            packet[18] = (byte)(ampU >> 8);
            packet[19] = (byte)(ampV);
            packet[20] = (byte)(ampV >> 8);
            packet[21] = (byte)(ampW);
            packet[22] = (byte)(ampW >> 8);

            packet[23] = (byte)(offU);
            packet[24] = (byte)(offU >> 8);
            packet[25] = (byte)(offV);
            packet[26] = (byte)(offV >> 8);
            packet[27] = (byte)(offW);
            packet[28] = (byte)(offW >> 8);

            return this.Communicate(5, packet);
        }


        private int Communicate(int countread, byte[] data)
        {
            int status = 0xFF;
            int read = 0;
            byte[] packet = null;


            if (data.Length <= 0)
            {
                return 0xFE;
            }
            else if (!mSerialPortOpen) {
                return 0xFD;
            }
            else
            {
                packet = new byte[data.Length];
            }


            try
            {
                mSerialPort.DiscardInBuffer();
                data.CopyTo(packet, 0);
                mSerialPort.Write(packet, 0, packet.Length);

                while (read < countread)
                {
                    read += mSerialPort.Read(mReceiveBuffer, read, countread - read);
                }

                status = mReceiveBuffer[3]; // Error status

            }
            catch (Exception e)
            {
                // Timed out
            }



            return status;



        }
    }

}
