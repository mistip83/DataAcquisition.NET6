using System;

namespace DataAcquisition.Core.Models.DTOs
{
    public class ExperimentDto
    {
        public int ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public string ExperimentDataId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}