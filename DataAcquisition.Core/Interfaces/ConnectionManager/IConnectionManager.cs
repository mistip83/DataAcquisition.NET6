using System.Collections.Generic;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.ConnectionManager
{
    public interface IConnectionManager
    {
        void Connect(ConnectionType connectionType);
        void Connect(List<ConnectionType> connectionTypeList);
        void Disconnect(ConnectionType connectionType);
    }
}