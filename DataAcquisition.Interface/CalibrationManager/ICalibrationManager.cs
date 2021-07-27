namespace DataAcquisition.Interface.CalibrationManager
{
    public interface ICalibrationManager
    {
        public ICalibration CreateEnergyCalibrator();
        public ICalibration CreateTemperatureCalibrator();
    }
}
