using System;

namespace DataAcquisition.Core.Interfaces.CalibrationManager
{
    public interface ICalibration
    {
        /// <summary>
        /// After calibration process completes, it returns last calibration date
        /// </summary>
        /// <param name="calibrationData"></param>
        public DateTime ApplyCalibrationData(string calibrationData);

        /// <summary>
        /// Returns calibration data from scanner
        /// </summary>
        /// <param name="channelAddressList"></param>
        string GetCalibrationData(int[] channelAddressList);
    }
}