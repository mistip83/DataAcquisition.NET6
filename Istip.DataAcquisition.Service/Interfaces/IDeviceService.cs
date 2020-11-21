using System.Collections.Generic;
using Istip.DataAcquisition.Service.Models;

namespace Istip.DataAcquisition.Service.Interfaces
{
    interface IDeviceService : IService<DeviceChannels>
    {
        bool AddDeviceToExperiment(DeviceChannels device);

        void SetDeviceChannels(IEnumerable<Channel> channelList);
    }
}
