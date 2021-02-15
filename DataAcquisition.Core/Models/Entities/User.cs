using System;
using System.Collections.Generic;

namespace DataAcquisition.Core.Models.Entities
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual Company Company { get; set; }
        public virtual IEnumerable<Experiment> Experiments { get; set; }
    }
}
