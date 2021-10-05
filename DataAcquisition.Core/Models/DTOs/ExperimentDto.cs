using System;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models.DTOs
{
    public class ExperimentDto
    {
        public int ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public ExperimentState ExperimentStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}