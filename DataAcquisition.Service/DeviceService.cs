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
        private readonly IDeviceManager _deviceManager;
        public DeviceService(IUnitOfWork unitOfWork, IRepository<Device> repository, 
            IDeviceManager deviceManager) : base(unitOfWork, repository)
        {
            _deviceManager = deviceManager;
        }

        public Device CalibrateDevice(Device device)
        {
            return _deviceManager.CalibrateDevice(device);
        }
    }
}
