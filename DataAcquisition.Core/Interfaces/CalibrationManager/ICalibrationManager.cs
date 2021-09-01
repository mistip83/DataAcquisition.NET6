using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Interfaces.CalibrationManager
{
    public interface ICalibrationManager
    {
        public ICalibration CreateCalibrator(DeviceType deviceType);
    }
}
