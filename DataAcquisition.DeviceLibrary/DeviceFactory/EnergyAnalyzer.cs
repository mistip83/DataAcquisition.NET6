using DataAcquisition.Core.Interfaces.DeviceManager;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class EnergyAnalyzer : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.EnergyAnalyzer();
    }
}