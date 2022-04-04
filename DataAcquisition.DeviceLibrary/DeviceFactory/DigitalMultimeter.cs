using DataAcquisition.Core.Interfaces.DeviceLibrary;

namespace DataAcquisition.DeviceLibrary.DeviceFactory;

/// <summary>
/// Overrides abstract class' methods
/// </summary>
public class DigitalMultimeter : AbstractFactory
{
    public override IDevice Create() => new DeviceLibrary.DigitalMultimeter();
}