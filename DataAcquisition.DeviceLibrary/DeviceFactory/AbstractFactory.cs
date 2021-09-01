using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public abstract class AbstractFactory
    {
        public abstract IDevice Create();
    }
}