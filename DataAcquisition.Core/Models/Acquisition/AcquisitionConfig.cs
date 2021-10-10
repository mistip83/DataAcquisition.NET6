using System;
using System.Collections.Generic;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models.Acquisition
{
    public class AcquisitionConfig
    {
        /// <summary>
        /// Experiment id
        /// </summary>
        public int ExperimentId { get; set; }

        /// <summary>
        /// Time difference between 2 measurements
        /// </summary>
        public TimeSpan TimeInterval { get; set; }

        /// <summary>
        /// Total measurement time for an experiment
        /// </summary> 
        public TimeSpan StopTime { get; set; }

        /// <summary>
        /// Device type used in experiment
        /// </summary> 
        public DeviceType DeviceType { get; set; }

        /// <summary>
        /// Connection type of device used in experiment
        /// </summary> 
        public ConnectionType ConnectionType { get; set; }

        /// <summary>
        /// Contain device channel id list
        /// </summary>
        public List<int> ChannelIdList { get; set; }
    }
}