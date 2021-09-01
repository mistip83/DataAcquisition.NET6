using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DisplayName { get; set; }
        public DateTime LastLogin { get; set; }
        public string CompanyName { get; set; }
        public virtual Company Company { get; set; }
        public virtual IEnumerable<Experiment> Experiments { get; set; }
    }
}
