using System;

namespace DataAcquisition.Model.License
{
    /// <summary>
    /// Model for license info comes from authorize.lic file
    /// </summary>
    public class LicenseFile
    {
        public string UserEmail { get; set; }
        public string MachineId { get; set; }
        public DateTime LicenseBeginDate { get; set; }
        public DateTime LicenseEndDate { get; set; }
        public DateTime OsDateTime { get; set; }
    }
}
