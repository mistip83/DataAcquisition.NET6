using System;
using DataAcquisition.Core.Interfaces.CalibrationManager;

namespace DataAcquisition.CalibrationManager.Decorator
{
    public abstract class CalibrationDecorator : ICalibration
    {
        private readonly ICalibration _calibrator;

        protected CalibrationDecorator(ICalibration calibrator)
        {
            _calibrator = calibrator;
        }

        /// <summary>
        /// After calibration process completes, it returns last calibration date
        /// </summary>
        /// <param name="calibrationData"></param>
        public DateTime ApplyCalibrationData(double[] calibrationData) => DateTime.UtcNow;

        /// <summary>
        /// Returns calibration data from scanner
        /// </summary>
        /// <param name="channelAddressList"></param>
        public virtual double[] GetCalibrationData(int[] channelAddressList)
        {
            return _calibrator.GetCalibrationData(channelAddressList);
        }
    }
}