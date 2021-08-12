using System;
using DataAcquisition.Interface.CalibrationManager;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Service
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class DeviceService : Service<Device>, IDeviceService
    {
        private readonly ICalibrationManager _calibrationManager;
        public DeviceService(IUnitOfWork unitOfWork, IRepository<Device> repository,
            ICalibrationManager calibrationManager) : base(unitOfWork, repository)
        {
            _calibrationManager = calibrationManager;
        }

        public void DoVoltageCalibration()
        {
            var energyCalibrator = _calibrationManager.CreateEnergyCalibrator();
            energyCalibrator.GetCalibrationData();
        }

        public void DoTemperatureCalibration()
        {
            throw new NotImplementedException();
        }
    }
}
