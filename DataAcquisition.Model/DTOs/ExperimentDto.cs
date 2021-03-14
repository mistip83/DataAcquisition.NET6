using System;

namespace DataAcquisition.Model.DTOs
{
    public class ExperimentDto
    {
        public string ExperimentName { get; set; }
        public string ExperimentDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}