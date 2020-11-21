using System;
using System.Collections.Generic;

namespace Istip.DataAcquisition.Service.Models
{
    public class DeviceChannels
    {
        public Guid DeviceId { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceName { get; set; }
        public IEnumerable<Channel> ChannelList { get; set; }
    }
}