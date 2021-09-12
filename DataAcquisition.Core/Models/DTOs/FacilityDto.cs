using System.Collections.Generic;
using DataAcquisition.Core.Models.Entities;

namespace DataAcquisition.Core.Models.DTOs
{
    public class FacilityDto
    {
        public int FacilityId { get; set; }
        public string FacilityName { get; set; }
        public string Address { get; set; }
        public int Employees { get; set; }
        public virtual ICollection<Workstation> Workstations { get; set; }
    }
}