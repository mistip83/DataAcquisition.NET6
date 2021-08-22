using DataAcquisition.DeviceLibrary.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class DataLogger : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.DataLogger();
    }
}