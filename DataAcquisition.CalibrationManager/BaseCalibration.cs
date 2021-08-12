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
            int[] channelAddressList = new int[5];
            return _deviceManager.ReadData(channelAddressList);
        }
    }
}