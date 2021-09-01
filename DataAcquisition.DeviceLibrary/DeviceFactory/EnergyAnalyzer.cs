using DataAcquisition.Core.Interfaces.DeviceManager;
using DataAcquisition.DeviceLibrary.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    public class EnergyAnalyzer : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.EnergyAnalyzer();
    }
}