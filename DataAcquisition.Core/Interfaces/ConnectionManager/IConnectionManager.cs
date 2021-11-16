using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ConnectionManager
{
    public interface IConnectionManager
    {
        void Connect(ConnectionType connectionType);
        void Disconnect(ConnectionType connectionType);
    }
}