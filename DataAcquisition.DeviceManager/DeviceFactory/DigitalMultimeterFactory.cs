using DataAcquisition.DeviceManager.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceManager.DeviceFactory
{
    public class DigitalMultimeterFactory : AbstractDeviceFactory
    {
        public override IDevice Create() => new DigitalMultimeter();
    }
}