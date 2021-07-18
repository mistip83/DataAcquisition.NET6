using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasKey(k => k.CompanyName);

            builder.Property(p => p.CompanyName)
                .HasMaxLength(100)
                .IsRequired();

        }
    }
}