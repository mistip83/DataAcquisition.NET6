using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string ConnectionProperties { get; set; }
        public virtual Workstation Workstation { get; set; }
        public virtual IEnumerable<Experiment> Experiments { get; set; }
    }
}