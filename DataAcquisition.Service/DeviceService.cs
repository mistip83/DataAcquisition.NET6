using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.ConnectionManager;
using DataAcquisition.Interface.DeviceManager;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Model.Entities;
using DataAcquisition.Model.Enums;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class DeviceService : Service<Device>, IDeviceService
    {
        private readonly ICalibrationManager _calibrationManager;
        private readonly IConnectionManager _connectionManager;
        private readonly IDeviceManager _deviceManager;
        public DeviceService(IUnitOfWork unitOfWork, IRepository<Device> repository,
            ICalibrationManager calibrationManager, IConnectionManager connectionManager, 
            IDeviceManager deviceManager) : base(unitOfWork, repository)
        {
            _calibrationManager = calibrationManager;
            _connectionManager = connectionManager;
            _deviceManager = deviceManager;
        }

        public Device CalibrateDevice(Device device)
        {
            _connectionManager.Connect(device.ConnectionType);

            var calibrator = CreateCalibrator(device.DeviceType);

            var channelAddressList = _deviceManager.GetChannelList(device.DeviceType);

            var calibrationData = calibrator.GetCalibrationData(channelAddressList);
            device.LastCalibrationDate = calibrator.ApplyCalibrationResult(calibrationData);

            _connectionManager.Disconnect(device.ConnectionType);

            return device;
        }

        private ICalibration CreateCalibrator(DeviceType deviceType)
        {
            return deviceType == DeviceType.DataLogger
                ? _calibrationManager.CreateTemperatureCalibrator()
                : _calibrationManager.CreateEnergyCalibrator();
        }
    }
}
