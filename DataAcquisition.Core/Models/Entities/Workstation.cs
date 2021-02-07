using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class Workstation
    {
        public Guid WorkStationId { get; set; }
        public string WorkStationName { get; set; }
        public virtual ICollection<Experiment> Experiments { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
