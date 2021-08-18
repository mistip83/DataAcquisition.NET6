using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceManager.DeviceFactory
{
    public abstract class AbstractDeviceFactory
    {
        public abstract IDevice Create();
    }
}