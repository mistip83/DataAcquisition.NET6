using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Facility
    {
        public Guid FacilityId { get; set; }
        public string FacilityName { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Workstation> WorkStations { get; set; }
    }
}
