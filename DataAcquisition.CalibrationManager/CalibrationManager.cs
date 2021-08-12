using System;
using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.CalibrationManager
{
    public class CalibrationManager : ICalibrationManager
    {
        private readonly IDeviceManager _deviceManager;

        public CalibrationManager(IDeviceManager deviceManager)
        {
            _deviceManager = deviceManager ?? throw new ArgumentNullException(nameof(deviceManager));
        }

        public ICalibration CreateEnergyCalibrator()
        {
            ICalibration energyCalibrator = new BaseCalibration(_deviceManager);
            return energyCalibrator;
        }

        public ICalibration CreateTemperatureCalibrator()
        {
            ICalibration temperatureCalibrator = new TemperatureCalibration(new BaseCalibration(_deviceManager));
            return temperatureCalibrator;
        }
    }
}
