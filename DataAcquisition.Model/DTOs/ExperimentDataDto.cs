using System.Collections.Generic;

namespace DataAcquisition.Model.DTOs
{
    public class ExperimentDataDto
    {
        public IEnumerable<string> ChannelNames { get; set; }
        public IEnumerable<string> ChannelUnits { get; set; }
        public string Data { get; set; }
    }
}