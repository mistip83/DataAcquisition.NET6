using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class ApplicationInfoConfiguration : IEntityTypeConfiguration<ApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfo> builder)
        {
            builder.HasKey(k => k.ApplicationName);
        }
    }
}