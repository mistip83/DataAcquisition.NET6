using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAcquisition.Core.Models.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }

        //[ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
        public virtual IEnumerable<Experiment> Experiments { get; set; }
    }
}
