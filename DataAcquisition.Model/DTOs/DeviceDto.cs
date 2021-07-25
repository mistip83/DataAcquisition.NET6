using DataAcquisition.Model.Enums;

namespace DataAcquisition.Model.DTOs
{
    public class DeviceDto
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DeviceType DeviceType { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public int WorkstationId { get; set; }
    }
}