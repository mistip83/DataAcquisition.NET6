using System;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ScannerManager;

namespace DataAcquisition.CalibrationManager
{
    public class CalibrationManager : ICalibrationManager
    {
        private readonly IScannerManager _scannerManager;

        public CalibrationManager(IScannerManager scannerManager)
        {
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
        }

        public ICalibration CreateEnergyCalibrator()
        {
            ICalibration energyCalibrator = new BaseCalibration(_scannerManager);
            return energyCalibrator;
        }

        public ICalibration CreateTemperatureCalibrator()
        {
            ICalibration temperatureCalibrator = new TemperatureCalibration(new BaseCalibration(_scannerManager));
            return temperatureCalibrator;
        }
    }
}
