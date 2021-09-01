using DataAcquisition.Core.Interfaces.DeviceManager;
using DataAcquisition.DeviceLibrary.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class DataLogger : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.DataLogger();
    }
}