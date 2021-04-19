using System;
using System.IO.Ports;
using System.Windows;

namespace Beep.Classes
{
    public static class BeepConnector
    {
        public static SerialPort connect()
        {
            var test = SerialPort.GetPortNames();
            
            if (SerialPort.GetPortNames().Length > 0)
            {
                return connect(SerialPort.GetPortNames()[0]);
            }

            return null;
        }
        
        private static SerialPort connect(string port)
        {
            try
            {
                SerialPort serialPort = new SerialPort();
                serialPort.PortName = port;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                return serialPort;
            }
            catch (Exception)    
            {
                //MessageBox.Show("Something went wrong connecting to beep");    
            }

            return null;
        }
    }
}