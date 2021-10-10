using System;

namespace DataAcquisition.Core.Models.DTOs
{
    public class ExperimentDataDto
    {
        public TimeSpan TimeInterval { get; set; }
        public string Data { get; set; }

    }
}