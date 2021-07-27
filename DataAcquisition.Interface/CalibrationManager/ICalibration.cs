namespace DataAcquisition.Interface.CalibrationManager
{
    public interface ICalibration
    {
        double GetCalibrationData(int channelAddress);
    }
}