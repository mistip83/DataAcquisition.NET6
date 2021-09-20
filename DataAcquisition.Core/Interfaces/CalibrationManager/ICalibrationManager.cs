using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.CalibrationManager
{
    /// <summary>
    /// Orchestrate calibration procedure
    /// </summary>
    /// <param name="device"></param>
    public interface ICalibrationManager
    {
        Device DoCalibration(Device device);
    }
}
