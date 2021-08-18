using DataAcquisition.DeviceManager.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceManager.DeviceFactory
{
    public class EnergyAnalyzerFactory : AbstractDeviceFactory
    {
        public override IDevice Create() => new EnergyAnalyzer();
    }
}