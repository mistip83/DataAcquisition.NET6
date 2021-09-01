using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.DeviceManager;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.DeviceManager
{
    public class DeviceManager : IDeviceManager
    {
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IConnectionManager _connectionManager;
        private readonly ICalibrationManager _calibrationManager;

        public DeviceManager(IDeviceLibraryManager deviceLibraryManager, 
            IConnectionManager connectionManager, ICalibrationManager calibrationManager)
        {
            _deviceLibraryManager = deviceLibraryManager;
            _connectionManager = connectionManager;
            _calibrationManager = calibrationManager;
        }

        public Device CalibrateDevice(Device device)
        {
            _connectionManager.Connect(device.ConnectionType);

            var calibrator = _calibrationManager.CreateCalibrator(device.DeviceType);

            var channelAddressList = GetChannelList(device.DeviceType);

            var calibrationData = calibrator.GetCalibrationData(channelAddressList);
            device.LastCalibrationDate = calibrator.ApplyCalibrationResult(calibrationData);

            _connectionManager.Disconnect(device.ConnectionType);

            return device;
        }

        public int[] GetChannelList(DeviceType deviceType)
        {
           return _deviceLibraryManager.ExecuteCreation(deviceType).ChannelAddressList();
        }
    }
}