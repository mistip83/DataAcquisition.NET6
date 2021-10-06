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
        /// List of device types used in experiment
        /// </summary> 
        public List<DeviceType> DeviceTypeList { get; set; }

        /// <summary>
        /// List of connection types of devices used in experiment
        /// </summary> 
        public List<ConnectionType> ConnectionTypeList { get; set; }

        /// <summary>
        /// Contain device types and channel properties for each device
        /// </summary>
        public List<AcquisitionChannelSetup> ChannelSetupList { get; set; }
    }
}