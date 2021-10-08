using System;

namespace DataAcquisition.Core.Models.Entities
{
    public class ExperimentDataDto
    {
        public TimeSpan TimeInterval { get; set; }
        public string Data { get; set; }

    }
}