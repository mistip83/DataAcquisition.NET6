using System.Collections.Generic;
using DataAcquisition.Core.Models.Device;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Interfaces.Services
{
    interface IDeviceService : IService<Device>
    {
        bool AddDeviceToExperiment(Device device);

        void SetDeviceChannels(IEnumerable<Channel> channelList);
    }
}
