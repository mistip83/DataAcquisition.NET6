using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class DigitalMultimeter : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.DigitalMultimeter();
    }
}