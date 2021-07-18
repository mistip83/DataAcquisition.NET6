using System;
using System.Collections.Generic;

namespace DataAcquisition.Model.Entities
{
    public class Company
    {
        public string CompanyName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
