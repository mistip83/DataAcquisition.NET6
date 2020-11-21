using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Istip.DataAcquisition.Core.EntityModels
{
    public class Facility
    {
        [Key]
        public Guid FacilityId { get; set; }
        public string FacilityName { get; set; }
        public Guid OrganizationId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<WorkStation> WorkStations { get; set; }
    }
}
