using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public abstract class AbstractFactory
    {
        public abstract IDevice Create();
    }
}