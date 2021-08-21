using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.ConnectionManager
{
    public interface IConnectionManager
    {
        public void Connect(ConnectionType connectionType);

        public void Disconnect(ConnectionType connectionType);
    }
}