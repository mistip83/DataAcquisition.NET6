using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class DeviceConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(x => x.DeviceId);

            builder.Property(p=>p.DeviceId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DeviceName)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.LastCalibrationDate)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.ConnectionType)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DeviceType)
                .HasColumnType("int")
                .IsRequired();

            // Device has one workstation
            builder.HasOne(f => f.Workstation)
                .WithMany(f => f.Devices)
                .HasForeignKey(f => f.WorkstationId);
        }
    }
}