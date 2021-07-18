using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Facility
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public int Employees { get; set; }
        public virtual ICollection<Workstation> WorkStations { get; set; }
    }
}
