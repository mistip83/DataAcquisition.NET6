using System;
using System.Collections.Generic;

namespace Istip.DataAcquisition.Core.EntityModels
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual ICollection<Facility> Facilities { get; set; }
    }
}
