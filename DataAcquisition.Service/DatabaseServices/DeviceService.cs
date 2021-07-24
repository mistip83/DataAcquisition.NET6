using System;
using DataAcquisition.Interface.Repositories;
using DataAcquisition.Interface.Services;
using DataAcquisition.Interface.UnitOfWorks;
using DataAcquisition.Model.Device;
using DataAcquisition.Model.Entities;

namespace DataAcquisition.Service.DatabaseServices
{
    /// <summary>
    /// Communicate with the API
    /// </summary>
    public class DeviceService : Service<Device>, IDeviceService
    {
        public DeviceService(IUnitOfWork unitOfWork, IRepository<Device> repository) : base(unitOfWork, repository)
        {
        }

        public Channel GetDeviceChannelInfo()
        {
            throw new NotImplementedException();
        }

        public void CalibrateDevice()
        {
            throw new NotImplementedException();
        }
    }
}
