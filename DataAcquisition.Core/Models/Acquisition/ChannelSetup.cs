namespace DataAcquisition.Core.Models.Acquisition
{
    /// <summary>
    /// Contain channel properties for each device
    /// </summary>
    public class ChannelSetup
    {
        public int[] ChannelIdList { get; set; }
        public string[] ChannelNameList { get; set; }
        public string[] ChannelUnitList { get; set; }
    }
}