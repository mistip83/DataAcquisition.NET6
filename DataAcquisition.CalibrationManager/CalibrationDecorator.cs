using DataAcquisition.Interface.CalibrationManager;

namespace DataAcquisition.CalibrationManager
{
    public abstract class CalibrationDecorator : ICalibrationManager
    {
        private readonly ICalibrationManager _calibrationManager;

        protected CalibrationDecorator(ICalibrationManager calibrationManager)
        {
            _calibrationManager = calibrationManager;
        }

        public virtual double GetCalibrationData(int channelAddress)
        {
            return _calibrationManager.GetCalibrationData(channelAddress);
        }
    }
}