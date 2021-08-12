using System;
using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.DeviceManager;

namespace DataAcquisition.CalibrationManager
{
    public class BaseCalibration: ICalibration
    {
        private readonly IDeviceManager _deviceManager;

        public BaseCalibration(IDeviceManager deviceManager)
        {
            _deviceManager = deviceManager ?? throw new ArgumentNullException(nameof(deviceManager));
        }

        public double[] GetCalibrationData()
        {
            _deviceManager.
            var rawData = _deviceManager.ReadData(channelAddress);
            return BitConverter.ToDouble(rawData);
        }
    }
}