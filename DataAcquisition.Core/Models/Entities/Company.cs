using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
