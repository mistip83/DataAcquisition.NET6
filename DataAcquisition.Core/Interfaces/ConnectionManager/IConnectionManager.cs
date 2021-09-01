using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ConnectionManager
{
    public interface IConnectionManager
    {
        public void Connect(ConnectionType connectionType);

        public void Disconnect(ConnectionType connectionType);
    }
}