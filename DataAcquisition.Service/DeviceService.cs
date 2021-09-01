using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceManager;
using DataAcquisition.Core.Interfaces.Repositories;
using DataAcquisition.Core.Interfaces.Services;
using DataAcquisition.Core.Interfaces.UnitOfWorks;
using DataAcquisition.Core.Models.Entities;

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
