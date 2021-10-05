using System;
using DataAcquisition.CalibrationManager.Decorator;
using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Interfaces.CalibrationManager;
using DataAcquisition.Core.Interfaces.ConnectionManager;
using DataAcquisition.Core.Interfaces.DeviceLibrary;
using DataAcquisition.Core.Interfaces.ScannerManager;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.CalibrationManager
{
    public class CalibrationManager : ICalibrationManager
    {
        private readonly IConnectionManager _connectionManager;
        private readonly IDeviceLibraryManager _deviceLibraryManager;
        private readonly IScannerManager _scannerManager;

        public CalibrationManager(IConnectionManager connectionManager, 
            IDeviceLibraryManager deviceLibraryManager, IScannerManager scannerManager)
        {
            _connectionManager = connectionManager ?? throw new ArgumentNullException(nameof(connectionManager));
            _deviceLibraryManager = deviceLibraryManager ?? throw new ArgumentNullException(nameof(deviceLibraryManager));
            _scannerManager = scannerManager ?? throw new ArgumentNullException(nameof(scannerManager));
        }

        /// <summary>
        /// Orchestrate calibration procedure
        /// </summary>
        /// <param name="device"></param>
        public Device DoCalibration(Device device)
        {
            // Establish connection with the device
            _connectionManager.Connect(device.ConnectionType);
            // Create calibrator regarding the device type
            var calibrator = CreateCalibrator(device.DeviceType);
            // Get all channel addresses for calibration 
            var channelAddressList = _deviceLibraryManager.GetChannelList(device.DeviceType);
            // Read data from each channel
            var calibrationData = calibrator.GetCalibrationData(channelAddressList);
            // Do calibration and update device's last calibration date
            device.LastCalibrationDate = calibrator.ApplyCalibrationData(calibrationData);
            // Close connection with device
            _connectionManager.Disconnect(device.ConnectionType);

            return device;
        }

        /// <summary>
        /// Decides which type of calibrator would be created
        /// </summary>
        /// <param name="deviceType"></param>
        private ICalibration CreateCalibrator(DeviceType deviceType)
        {
            return deviceType == DeviceType.DataLogger
                ? CreateTemperatureCalibrator()
                : CreateEnergyCalibrator();
        }

        /// <summary>
        /// Creates a base calibrator object
        /// </summary>
        private ICalibration CreateEnergyCalibrator()
        {
            return new BaseCalibration(_scannerManager);
        }

        /// <summary>
        /// Creates a calibrator object with extra functionality
        /// </summary>
        private ICalibration CreateTemperatureCalibrator()
        {
            return new TemperatureCalibration(new BaseCalibration(_scannerManager));
        }
    }
}
