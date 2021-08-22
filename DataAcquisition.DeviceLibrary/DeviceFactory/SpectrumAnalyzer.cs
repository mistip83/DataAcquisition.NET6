using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class SpectrumAnalyzer : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.EnergyAnalyzer();
    }
}