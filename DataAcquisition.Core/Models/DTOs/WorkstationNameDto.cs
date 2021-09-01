using System.Collections.Generic;

namespace DataAcquisition.Core.Models.DTOs
{
    public class WorkstationNameDto
    {
        public string WorkstationName { get; set; }
        public IEnumerable<ExperimentNameDto> Experiments { get; set; }
    }
}