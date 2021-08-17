using System;
using System.IO.Ports;
using DataAcquisition.Interface.ConnectionManager;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.ConnectionManager
{
    public class ConnectionManager : IConnectionManager
    {
        private SerialPort _serialPort;
        public void ConnectToDevice(ConnectionType connectionType)
        {
            _serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None, WriteTimeout = 500
            };

            _serialPort.Open();

            Console.WriteLine("Connected to Device");
        }

        public void ConnectToSimulator()
        {
            Console.WriteLine("Connected to Simulator");
        }
    }
}