using System;

namespace DataAcquisition.Core.Models.DTOs
{
    public class ExperimentDto
    {
        public int ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public string ChannelNames { get; set; }
        public string ChannelUnits { get; set; }
        public int WorkstationId { get; set; }
        public string Email { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}