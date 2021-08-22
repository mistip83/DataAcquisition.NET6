using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public abstract class AbstractFactory
    {
        public abstract IDevice Create();
    }
}