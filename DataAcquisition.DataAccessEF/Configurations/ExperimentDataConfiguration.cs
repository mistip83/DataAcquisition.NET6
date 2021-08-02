using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class ExperimentDataConfiguration : IEntityTypeConfiguration<ExperimentData>
    {
        public void Configure(EntityTypeBuilder<ExperimentData> builder)
        {
            builder.HasKey(k => k.ExperimentId);
        }
    }
}