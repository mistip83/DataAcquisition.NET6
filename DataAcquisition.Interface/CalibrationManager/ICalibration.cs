using System;

namespace DataAcquisition.Interface.CalibrationManager
{
    public interface ICalibration
    {
        double[] GetCalibrationData(int[] channelAddressList);
        public DateTime ApplyCalibrationResult(double[] calibrationData);
    }
}