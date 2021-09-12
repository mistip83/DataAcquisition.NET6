using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.DTOs
{
    public class MeasurementDto
    {
        /// <summary>
        /// Time difference between 2 measurements
        /// </summary>
        public TimeSpan TimeInterval { get; set; }

        /// <summary>
        /// Total measurement time for an experiment
        /// </summary> 
        public TimeSpan StopTime { get; set; }

        /// <summary>
        /// Contain channel properties for each device
        /// </summary>
        public IEnumerable<ChannelConfiguration> ChannelConfigList { get; set; }
    }
}