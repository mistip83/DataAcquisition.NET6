using System;

namespace DataAcquisition.Interface.Models.Entities
{
    public class ApplicationInfo
    {
        public string ApplicationName { get; set; }
        public string Version { get; set; }
        public DateTime FirstInstallDate { get; set; }
        public DateTime LastUpdateDate{ get; set; }
    }
}
