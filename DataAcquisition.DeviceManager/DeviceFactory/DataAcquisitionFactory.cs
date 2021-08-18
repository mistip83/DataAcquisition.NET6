using DataAcquisition.DeviceManager.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceManager.DeviceFactory
{
    public class DataAcquisitionFactory : AbstractDeviceFactory
    {
        public override IDevice Create() => new DataLogger();
    }
}