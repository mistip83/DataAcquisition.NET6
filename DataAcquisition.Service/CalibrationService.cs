using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Models.Entities;
using System;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class CalibrationService : ICalibrationService
    {
        private readonly ICalibrationManager _calibrationManager;

        public CalibrationService(ICalibrationManager calibrationManager)
        {
            _calibrationManager = calibrationManager;
        }

        /// <summary>
        /// Calibrates device and updates last calibration date 
        /// </summary>
        /// <param name="device"></param>
        public Device CalibrateDevice(Device device)
        {
            return _calibrationManager.DoCalibration(device);
        }
    }
}
