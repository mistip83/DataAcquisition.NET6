using System;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ScannerManager;

namespace DataAcquisition.CalibrationManager.Decorator
{
    public class BaseCalibration : ICalibration
    {
        private readonly IScannerManager _scannerManager;

        public BaseCalibration(IScannerManager scannerManager)
        {
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
        }

        public DateTime ApplyCalibrationData(string calibrationData) => DateTime.UtcNow;

        public string GetCalibrationData(int[] channelAddressList) =>
         _scannerManager.GetData(channelAddressList);
    }
}