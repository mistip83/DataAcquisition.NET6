using DataAcquisition.Core.Enums;
using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData;

public class DeviceSeed : IEntityTypeConfiguration<Device>
{
    public void Configure(EntityTypeBuilder<Device> builder)
    {
        builder.HasData(new Device()
        {
            DeviceId = 1,
            DeviceName = "DAQ1",
            DeviceType = DeviceType.DataLogger,
            ConnectionType = ConnectionType.TcpIp,
            LastCalibrationDate = DateTime.UtcNow,
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 2,
            DeviceName = "NetworkAnalyzer1",
            DeviceType = DeviceType.SpectrumAnalyzer,
            ConnectionType = ConnectionType.TcpIp,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 3,
            DeviceName = "EnergyAnalyzer1",
            DeviceType = DeviceType.EnergyAnalyzer,
            ConnectionType = ConnectionType.Usb,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 4,
            DeviceName = "EnergyAnalyzer2",
            DeviceType = DeviceType.EnergyAnalyzer,
            ConnectionType = ConnectionType.Usb,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 5,
            DeviceName = "DigitalMultimeter1",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 6,
            DeviceName = "DigitalMultimeter2",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 7,
            DeviceName = "DigitalMultimeter3",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 1
        });

        builder.HasData(new Device()
        {
            DeviceId = 8,
            DeviceName = "DAQ1",
            DeviceType = DeviceType.DataLogger,
            ConnectionType = ConnectionType.TcpIp,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 2
        });

        builder.HasData(new Device()
        {
            DeviceId = 9,
            DeviceName = "DAQ2",
            DeviceType = DeviceType.DataLogger,
            ConnectionType = ConnectionType.TcpIp,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 2
        });

        builder.HasData(new Device()
        {
            DeviceId = 10,
            DeviceName = "EnergyAnalyzer1",
            DeviceType = DeviceType.EnergyAnalyzer,
            ConnectionType = ConnectionType.Usb,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 3
        });

        builder.HasData(new Device()
        {
            DeviceId = 11,
            DeviceName = "DigitalMultimeter1",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 4
        });

        builder.HasData(new Device()
        {
            DeviceId = 12,
            DeviceName = "DigitalMultimeter2",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 4
        });

        builder.HasData(new Device()
        {
            DeviceId = 13,
            DeviceName = "EnergyAnalyzer1",
            DeviceType = DeviceType.EnergyAnalyzer,
            ConnectionType = ConnectionType.Usb,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 5
        });

        builder.HasData(new Device()
        {
            DeviceId = 14,
            DeviceName = "DigitalMultimeter1",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 4
        });

        builder.HasData(new Device()
        {
            DeviceId = 15,
            DeviceName = "DigitalMultimeter2",
            DeviceType = DeviceType.DigitalMultimeter,
            ConnectionType = ConnectionType.Rs485,
            LastCalibrationDate = DateTime.UtcNow.AddYears(-2),
            WorkstationId = 4
        });
    }
}