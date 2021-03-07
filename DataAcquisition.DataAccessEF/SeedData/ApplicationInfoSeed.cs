using System;
using DataAcquisition.Interface.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class ApplicationInfoSeed : IEntityTypeConfiguration<ApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfo> builder)
        {
            builder.HasData(
                new ApplicationInfo()
                {
                    ApplicationName = "DataAcquisition",
                    Version = "1.0.0",
                    FirstInstallDate = DateTime.Now,
                    LastUpdateDate = DateTime.Now
                });
        }
    }
}