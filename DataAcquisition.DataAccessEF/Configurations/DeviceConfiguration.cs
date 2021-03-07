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

            // Device has many experiment
            //builder.HasMany((p => p.Experiments))
            //    .WithMany(p => p.Devices);

            //// Device has one workstation
            //builder.HasOne(p => p.Workstation)
            //    .WithMany(p => p.Devices)
            //    .HasForeignKey(p => p.DeviceId);
        }
    }
}