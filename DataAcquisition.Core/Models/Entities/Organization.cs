using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcquisition.Core.Models.Entities
{
    public class Organization
    {
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
