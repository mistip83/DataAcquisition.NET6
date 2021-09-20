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
        public DeviceService(IUnitOfWork unitOfWork, IRepository<Device> repository) : base(unitOfWork, repository)
        {
        }
    }
}
