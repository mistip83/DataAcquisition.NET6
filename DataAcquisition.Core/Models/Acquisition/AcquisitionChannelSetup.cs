using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Acquisition
{
    /// <summary>
    /// Contain channel properties for each device
    /// </summary>
    public class AcquisitionChannelSetup
    {
        public List<int> ChannelIdList { get; set; }
        public List<string> ChannelNameList { get; set; }
        public List<string> ChannelUnitList { get; set; }
    }
}