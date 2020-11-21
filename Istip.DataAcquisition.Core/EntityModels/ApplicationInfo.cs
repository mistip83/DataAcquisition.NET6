using System;

namespace Istip.DataAcquisition.Core.EntityModels
{
    public class ApplicationInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public DateTime FirstInstallDateTime { get; set; }
        public DateTime LastUpdateDateTime{ get; set; }
    }
}
