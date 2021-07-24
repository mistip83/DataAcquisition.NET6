using System;
using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.CalibrationManager
{
    public class CalibrationManager : ICalibrationManager
    {
        private readonly IDeviceManager _deviceManager;

        public CalibrationManager(IDeviceManager deviceManager)
        {
            _deviceManager = deviceManager;
        }

        public double GetCalibrationData(int channelAddress)
        {
            var rawData = _deviceManager.ReadData(channelAddress);
            return BitConverter.ToDouble(rawData);
        }
    }
}
