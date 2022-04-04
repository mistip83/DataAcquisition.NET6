using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory;

/// <summary>
/// Overrides abstract class' methods
/// </summary>
public class EnergyAnalyzer : AbstractFactory
{
    public override IDevice Create() => new DeviceLibrary.EnergyAnalyzer();
}