using System;

namespace DataAcquisition.Core.Interfaces.CalibrationManager
{
    public interface ICalibration
    {
        double[] GetCalibrationData(int[] channelAddressList);
        public DateTime ApplyCalibrationResult(double[] calibrationData);
    }
}