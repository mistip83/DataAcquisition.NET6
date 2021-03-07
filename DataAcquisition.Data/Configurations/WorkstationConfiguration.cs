using DataAcquisition.Interface.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.Configurations
{
    public class WorkstationConfiguration : IEntityTypeConfiguration<Workstation>
    {
        public void Configure(EntityTypeBuilder<Workstation> builder)
        {
            builder.HasKey(x => x.WorkstationId);

            // Workstation has many experiments
            //builder.HasMany(p => p.Experiments)
            //    .WithOne(p => p.WorkStation)
            //    .HasForeignKey(p => p.ExperimentId);

            //// Workstation has one facility
            //builder.HasOne(p => p.Facility)
            //    .WithMany(p => p.WorkStations)
            //    .HasForeignKey(p => p.WorkstationId);
        }
    }
}