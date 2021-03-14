using System;

namespace DataAcquisition.Model.Entities
{
    public class Device
    {
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string ConnectionProperties { get; set; }
        public Guid WorkstationId { get; set; }
        public virtual Workstation Workstation { get; set; }
    }
}