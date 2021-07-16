using System.Collections.Generic;

namespace DataAcquisition.Model.Device
{
    public class Configuration
    {
        public string DeviceId { get; set; }
        public IEnumerable<ChannelInfo> ChannelList { get; set; }
    }
}