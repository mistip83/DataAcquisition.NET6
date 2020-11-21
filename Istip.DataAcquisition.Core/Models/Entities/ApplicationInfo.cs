using System;

namespace Istip.DataAcquisition.Core.Models.Entities
{
    public class ApplicationInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime FirstInstallDateTime { get; set; }
        public DateTime LastUpdateDateTime{ get; set; }
    }
}
