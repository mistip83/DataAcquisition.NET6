using System;
using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class ApplicationInfoSeed : IEntityTypeConfiguration<ApplicationInfo>
    {
        public void Configure(EntityTypeBuilder<ApplicationInfo> builder)
        {
            builder.HasData(
                new ApplicationInfo()
                {
                    Name = "DataAcquisition",
                    Version = "1.0.0",
                    FirstInstallDateTime = DateTime.Now,
                    LastUpdateDateTime = DateTime.Now
                });
        }
    }
}