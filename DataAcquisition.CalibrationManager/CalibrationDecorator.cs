using System;
using DataAcquisition.Core.Interfaces.CalibrationManager;

namespace DataAcquisition.CalibrationManager
{
    public abstract class CalibrationDecorator : ICalibration
    {
        private readonly ICalibration _calibrator;

        protected CalibrationDecorator(ICalibration calibrator)
        {
            _calibrator = calibrator;
        }

        public DateTime ApplyCalibrationData(double[] calibrationData)
        {
            return DateTime.UtcNow;
        }

        public virtual double[] GetCalibrationData(int[] channelAddressList)
        {
            return _calibrator.GetCalibrationData(channelAddressList);
        }
    }
}