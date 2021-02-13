using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(x => x.CompanyId);

            // Company has many users
            //builder.HasMany(p => p.Users)
            //    .WithOne(p => p.Company)
            //    .HasForeignKey(p => p.UserId);

            //// Company has many facilities
            //builder.HasMany((p => p.Facilities))
            //    .WithOne(p => p.Company)
            //    .HasForeignKey(p => p.FacilityId);
        }
    }
}