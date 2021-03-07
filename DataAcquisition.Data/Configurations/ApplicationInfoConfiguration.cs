using DataAcquisition.Interface.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.Configurations
{
    public class ApplicationInfoConfiguration : IEntityTypeConfiguration<ApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfo> builder)
        {
            builder.HasKey(x => x.ApplicationName);
        }
    }
}