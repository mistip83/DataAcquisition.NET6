using System;
using System.IO.Ports;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.ConnectionManager;

namespace DataAcquisition.ConnectionManager
{
    // TODO: Refactor
    public class ConnectionManager : IConnectionManager
    {
        private SerialPort _serialPort;
        public void Connect(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.TcpIp:
                    ConnectToTcp();
                    break;
                case ConnectionType.Usb:
                    ConnectToUsb();
                    break;
                case ConnectionType.Rs485:
                    ConnectToSerialPort();
                    break;
                default:
                    break;
            }
        }

        public void Disconnect(ConnectionType connectionType)
        {
            switch (connectionType)
            {
                case ConnectionType.TcpIp:
                    DisconnectTcp();
                    break;
                case ConnectionType.Usb:
                    DisconnectUsb();
                    break;
                case ConnectionType.Rs485:
                    DisconnectSerialPort();
                    break;
                default:
                    break;
            }

            _serialPort.Close();
            Console.WriteLine("Connected to Simulator");
        }

        private void ConnectToTcp()
        {
            Console.WriteLine("Connected to Device");
        }

        private void ConnectToUsb()
        {
            Console.WriteLine("Connected to Device");
        }

        private void ConnectToSerialPort()
        {
            _serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None,
                WriteTimeout = 500
            };

            _serialPort.Open();
            Console.WriteLine("Connected to Device");
        }

        private void DisconnectTcp()
        {
            Console.WriteLine("Disconnected from Device");
        }

        private void DisconnectUsb()
        {
            Console.WriteLine("Disconnected from Device");
        }

        private void DisconnectSerialPort()
        {
            Console.WriteLine("Disconnected from Device");
        }
    }
}