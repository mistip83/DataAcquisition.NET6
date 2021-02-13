using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Device
{
    public class Configuration
    {
        public string DeviceId { get; set; }
        public IEnumerable<Channel> ChannelList { get; set; }
    }
}