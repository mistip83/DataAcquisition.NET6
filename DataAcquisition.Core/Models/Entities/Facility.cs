using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class Facility
    {
        [Key]
        public Guid FacilityId { get; set; }
        public string FacilityName { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Workstation> WorkStations { get; set; }
        public virtual User User { get; set; }
    }
}
