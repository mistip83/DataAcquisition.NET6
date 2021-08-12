using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.CalibrationManager
{
    public abstract class CalibrationDecorator : ICalibration
    {
        private readonly ICalibration _calibrator;

        protected CalibrationDecorator(ICalibration calibrator)
        {
            _calibrator = calibrator;
        }

        public virtual double[] GetCalibrationData()
        {
            return _calibrator.GetCalibrationData();
        }
    }
}