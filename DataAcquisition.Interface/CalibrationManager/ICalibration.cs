using DataAcquisition.Model.Enums;

namespace DataAcquisition.Interface.CalibrationManager
{
    public interface ICalibration
    {
        double[] GetCalibrationData();
    }
}