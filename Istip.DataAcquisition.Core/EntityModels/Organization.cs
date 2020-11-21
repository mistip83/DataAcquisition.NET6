using System;
using System.Collections.Generic;

namespace Istip.DataAcquisition.Core.EntityModels
{
    public class Organization
    {
        public Guid OrganizationId { get; set; }
        public string OrganizationName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
