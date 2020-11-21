using System.Collections.Generic;
using Istip.DataAcquisition.Core.Models.Services;

namespace Istip.DataAcquisition.Core.Interfaces.Services
{
    interface IDeviceService : IService<DeviceChannels>
    {
        bool AddDeviceToExperiment(DeviceChannels device);

        void SetDeviceChannels(IEnumerable<Channel> channelList);
    }
}
