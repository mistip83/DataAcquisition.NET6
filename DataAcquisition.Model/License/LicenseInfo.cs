using System;

namespace DataAcquisition.Model.License
{
    /// <summary>
    /// Model for license info comes from authorize.lic file
    /// </summary>
    public class LicenseInfo
    {
        public string UserEmail { get; }
        public string MachineId { get; }
        public DateTime LicenseBeginDate { get; }
        public DateTime LicenseEndDate { get; }
        public DateTime OsDateTime { get; set; }
    }
}
