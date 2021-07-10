using System.IO.Ports;
using DataAcquisition.Interface.ConnectionManager;

namespace DataAcquisition.ConnectionManager
{
    public class ConnectionManager : IConnectionManager
    {
        private SerialPort _serialPort;
        public void ConnectToDevice()
        {
            _serialPort = new SerialPort("COM1", 19200, Parity.None, 8, StopBits.One)
            {
                Handshake = Handshake.None, WriteTimeout = 500
            };

            _serialPort.Open();
        }

        public void ConnectToSimulator()
        {
            throw new System.NotImplementedException();
        }
    }
}