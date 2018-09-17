using System;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Ports;

namespace AinaKeypad
{
    class SerialReader
    {
        private SerialPort serialPort;
        private Form1 app;
        public SerialReader(Form1 mainApp)
        {
            this.app = mainApp;
            serialPort = new SerialPort("COM5", 9600);
            //ConnectAinaBoard("COM5");
        }

        public bool ConnectAinaBoard(string port)
        {
            if (serialPort.IsOpen)
            {
                DisconnectAinaBoard();
            }
            try
            {
                serialPort.PortName = port;
                //mySerialPort.BaudRate = 9600;
                //mySerialPort.Parity = Parity.None;
                //mySerialPort.StopBits = StopBits.Two;
                //mySerialPort.DataBits = 8;
                //mySerialPort.Handshake = Handshake.None;
                //mySerialPort.RtsEnable = false;

                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                serialPort.Open();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
            // Console.WriteLine("Press any key to continue...");
            // Console.WriteLine();
            // Console.ReadKey();
            //mySerialPort.Close();
        }

        public bool isOpen()
        {
            return serialPort.IsOpen;
        }

        public void DisconnectAinaBoard()
        {
            serialPort.Close();
        }

        private void DataReceivedHandler(
                            object sender,
                            SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();
            app.processSerialInput(indata);
            //sp.ReadExisting();            
            // Console.WriteLine("Data Received:");
            //Console.WriteLine(indata);
            //  Console.WriteLine();
        }

        public void writeLine(string text)
        {
            this.serialPort.WriteLine(text);
        }

        ~SerialReader()
        {
            serialPort.Close();
        }
    }
}
