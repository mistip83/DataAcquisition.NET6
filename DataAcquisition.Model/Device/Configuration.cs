using System.Collections.Generic;

namespace DataAcquisition.Model.Device
{
    public class Configuration
    {
        public string DeviceId { get; set; }
        public IEnumerable<Channel> ChannelList { get; set; }
    }
}