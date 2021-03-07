using System.Collections.Generic;

namespace DataAcquisition.Interface.Models.Device
{
    public class Configuration
    {
        public string DeviceId { get; set; }
        public IEnumerable<Channel> ChannelList { get; set; }
    }
}