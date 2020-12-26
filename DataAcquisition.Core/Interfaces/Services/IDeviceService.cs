using System.Collections.Generic;
using DataAcquisition.Core.Models.Services;

namespace DataAcquisition.Core.Interfaces.Services
{
    interface IDeviceService : IService<DeviceChannels>
    {
        bool AddDeviceToExperiment(DeviceChannels device);

        void SetDeviceChannels(IEnumerable<Channel> channelList);
    }
}
