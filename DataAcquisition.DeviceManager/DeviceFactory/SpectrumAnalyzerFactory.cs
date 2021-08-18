using DataAcquisition.DeviceManager.DeviceLibrary;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceManager.DeviceFactory
{
    public class SpectrumAnalyzerFactory : AbstractDeviceFactory
    {
        public override IDevice Create() => new EnergyAnalyzer();
    }
}