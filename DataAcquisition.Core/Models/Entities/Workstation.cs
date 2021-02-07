using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class Workstation
    {
        [Key]
        public Guid WorkStationId { get; set; }
        public string WorkStationName { get; set; }
        public virtual ICollection<Experiment> Experiments { get; set; }
        public virtual Facility Facility { get; set; }
    }
}
