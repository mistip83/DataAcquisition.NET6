using System;
using System.Collections.Generic;

namespace DataAcquisition.Interface.Models.Entities
{
    public class Company
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
