using System.Collections.Generic;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models
{
    /// <summary>
    /// Contain channel properties for each device
    /// </summary>
    public class ChannelConfiguration
    {
        public DeviceType DeviceType { get; set; }
        public IEnumerable<int> ChannelIdList { get; set; }
        public IEnumerable<string> ChannelNameList { get; set; }
        public IEnumerable<string> ChannelUnitList { get; set; }
    }
}