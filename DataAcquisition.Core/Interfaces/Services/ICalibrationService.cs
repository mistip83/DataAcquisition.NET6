using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services;

public interface ICalibrationService
{
    /// <summary>
    /// Calibrates device and updates last calibration date 
    /// </summary>
    /// <param name="device"></param>
    /// <returns></returns>
    Device CalibrateDevice(Device device);
}