using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class Company
    {
        public string CompanyName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
