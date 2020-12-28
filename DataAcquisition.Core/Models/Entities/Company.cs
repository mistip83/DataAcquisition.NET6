using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DataAcquisition.Core.Models.Entities
{
    public class Company
    {
        public Company()
        {
          Users = new Collection<User>();
        }

        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
