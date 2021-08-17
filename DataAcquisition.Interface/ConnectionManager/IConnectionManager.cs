using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.ConnectionManager
{
    public interface IConnectionManager
    {
        public void ConnectToDevice(ConnectionType connectionType);

        public void ConnectToSimulator();
    }
}