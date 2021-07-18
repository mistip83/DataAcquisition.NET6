using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class ExperimentConfiguration : IEntityTypeConfiguration<Experiment>
    {
        public void Configure(EntityTypeBuilder<Experiment> builder)
        {
            builder.HasKey(x => x.ExperimentId);

            builder.Property(p => p.ExperimentId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ExperimentName)
                .HasMaxLength(100)
                .IsRequired();

            //// Experiment has one workstation
            //builder.HasOne(p => p.WorkStation)
            //    .WithMany(p => p.Experiments)
            //    .HasForeignKey(p => p.ExperimentId);
        }
    }
}