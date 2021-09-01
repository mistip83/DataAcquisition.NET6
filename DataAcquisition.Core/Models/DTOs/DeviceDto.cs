using System;
using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models.DTOs
{
    public class DeviceDto
    {
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public DeviceType DeviceType { get; set; }
        public ConnectionType ConnectionType { get; set; }
        public DateTime LastCalibrationDate { get; set; }
        public int WorkstationId { get; set; }
    }
}