using System.Collections.Generic;

namespace DataAcquisition.Model.DeviceProperties
{
    public class Configuration
    {
        public string DeviceId { get; set; }
        public IEnumerable<Channel> ChannelList { get; set; }
    }
}