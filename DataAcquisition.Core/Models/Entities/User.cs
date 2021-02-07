using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        public virtual Company Company { get; set; }
    }
}
