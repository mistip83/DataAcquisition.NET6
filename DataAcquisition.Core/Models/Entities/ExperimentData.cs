using System;

namespace DataAcquisition.Core.Models.Entities
{
    public class ExperimentData
    {
        public int ExperimentId { get; set; }
        public TimeSpan TimeInterval { get; set; }
        public string Data { get; set; }
    }
}