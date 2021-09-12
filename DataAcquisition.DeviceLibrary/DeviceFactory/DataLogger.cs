using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class DataLogger : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.DataLogger();
    }
}