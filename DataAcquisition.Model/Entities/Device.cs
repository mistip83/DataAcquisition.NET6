using DataAcquisition.Model.Enums;
using System;

namespace DataAcquisition.Model.Entities
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DeviceType DeviceType { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public int WorkstationId { get; set; }
        public virtual Workstation Workstation { get; set; }
    }
}