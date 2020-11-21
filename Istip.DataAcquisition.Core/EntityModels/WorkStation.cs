using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istip.DataAcquisition.Core.EntityModels
{
    public class Workstation
    {
        public Guid WorkStationId { get; set; }
        public string WorkStationName { get; set; }
        public virtual ICollection<Experiment> Experiments { get; set; }

        [ForeignKey("FacilityId")]
        public virtual Facility Facility { get; set; }
    }
}
