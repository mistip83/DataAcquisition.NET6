using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class ExperimentData
    {
        public int ExperimentId { get; set; }
        public IEnumerable<string> ChannelNames { get; set; }
        public IEnumerable<string> ChannelUnits { get; set; }
        public string Data { get; set; }
    }
}