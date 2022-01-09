using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory
{
    /// <summary>
    /// Overrides abstract class' methods
    /// </summary>
    public class SpectrumAnalyzer : AbstractFactory
    {
        public override IDevice Create() => new DeviceLibrary.EnergyAnalyzer();
    }
}