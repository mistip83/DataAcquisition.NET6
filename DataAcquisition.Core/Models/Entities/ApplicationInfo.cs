using System;
using System.ComponentModel.DataAnnotations;

namespace DataAcquisition.Core.Models.Entities
{
    public class ApplicationInfo
    {
        [Key]
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime FirstInstallDateTime { get; set; }
        public DateTime LastUpdateDateTime{ get; set; }
    }
}
