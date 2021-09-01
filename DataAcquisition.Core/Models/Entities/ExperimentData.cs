namespace DataAcquisition.Core.Models.Entities
{
    public class ExperimentData
    {
        public int ExperimentId { get; set; }
        public string ChannelNames { get; set; }
        public string ChannelUnits { get; set; }
        public string Data { get; set; }
    }
}