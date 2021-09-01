namespace DataAcquisition.Core.Interfaces.CalibrationManager
{
    public interface ICalibrationManager
    {
        public ICalibration CreateEnergyCalibrator();
        public ICalibration CreateTemperatureCalibrator();
    }
}
