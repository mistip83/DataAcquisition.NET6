using System.Collections.Generic;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models.Acquisition
{
    /// <summary>
    /// Contain channel properties for each device
    /// </summary>
    public class ChannelConfiguration
    {
        public DeviceType DeviceType { get; set; }
        public List<int> ChannelIdList { get; set; }
        public List<string> ChannelNameList { get; set; }
        public List<string> ChannelUnitList { get; set; }
    }
}