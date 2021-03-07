using DataAcquisition.Interface.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class ExperimentConfiguration : IEntityTypeConfiguration<Experiment>
    {
        public void Configure(EntityTypeBuilder<Experiment> builder)
        {
            builder.HasKey(x => x.ExperimentId);

            // Experiment has many devices
            //builder.HasMany(p => p.Devices)
            //    .WithMany(p=>p.Experiments);

            //// Experiment has one workstation
            //builder.HasOne(p => p.WorkStation)
            //    .WithMany(p => p.Experiments)
            //    .HasForeignKey(p => p.ExperimentId);
        }
    }
}