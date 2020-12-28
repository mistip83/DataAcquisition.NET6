using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
        public virtual Company Company { get; set; }
    }
}
