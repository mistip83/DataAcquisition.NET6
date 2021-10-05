using System;
using System.Collections.Generic;
using System.IO.Ports;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ConnectionManager;

namespace DataAcquisition.ConnectionManager
{
    // TODO: Get connection properties for each connection type
    public class ConnectionManager : IConnectionManager
    {
        private SerialPort _serialPort;
        public void Connect(ConnectionType connectionType)
        {
            _serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None, WriteTimeout = 500
            };

            _serialPort.Open();
            Console.WriteLine("Connected to Device");
        }

        public void Connect(List<ConnectionType> connectionTypeList)
        {
            foreach (var connectionType in connectionTypeList)
            {
                Console.WriteLine("Connected to Device");
            }
        }

        public void Disconnect(ConnectionType connectionType)
        {
            _serialPort.Close();
            Console.WriteLine("Connected to Simulator");
        }
    }
}