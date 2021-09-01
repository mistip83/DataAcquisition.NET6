using System;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ScannerManager;

namespace DataAcquisition.CalibrationManager
{
    public class BaseCalibration: ICalibration
    {
        private readonly IScannerManager _scannerManager;

        public BaseCalibration(IScannerManager scannerManager)
        {
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
        }

        public DateTime ApplyCalibrationResult(double[] calibrationData)
        {
            return DateTime.UtcNow;
        }

        public double[] GetCalibrationData(int[] channelAddressList)
        {
            return _scannerManager.ReadData(channelAddressList);
        }
    }
}