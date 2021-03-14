using System;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        private readonly Company _company;

        public CompanySeed(Company company)
        {
            _company = company;
        }

        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(_company);
        }
    }
}