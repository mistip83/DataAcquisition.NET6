using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class Experiment
    {
        public Guid ExperimentId { get; set; }
        public string ExperimentName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual Workstation WorkStation { get; set; }
    }
}
