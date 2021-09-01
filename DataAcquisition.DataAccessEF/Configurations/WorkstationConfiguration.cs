using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class WorkstationConfiguration : IEntityTypeConfiguration<Workstation>
    {
        public void Configure(EntityTypeBuilder<Workstation> builder)
        {
            builder.HasKey(x => x.WorkstationId);

            builder.Property(p => p.WorkstationId)
                .ValueGeneratedOnAdd();
        }
    }
}