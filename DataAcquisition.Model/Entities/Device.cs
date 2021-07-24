using DataAcquisition.Model.Enums;

namespace DataAcquisition.Model.Entities
{
    public class Device
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DeviceType DeviceType { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public bool IsDeleted { get; set; }
        public int WorkstationId { get; set; }
        public virtual Workstation Workstation { get; set; }
    }
}