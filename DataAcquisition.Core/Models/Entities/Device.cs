using DataAcquisition.Core.Enums;

namespace DataAcquisition.Core.Models.Entities;

public class Device
{
    public int DeviceId { get; set; }
    public string DeviceName { get; set; }
    public DeviceType DeviceType { get; set; }
    public ConnectionType ConnectionType { get; set; }
    public string SerialNo { get; set; }
    public DateTime InstallationDate { get; set; }
    public DateTime LastCalibrationDate { get; set; }
    public int WorkstationId { get; set; }
    public virtual Workstation Workstation { get; set; }
}