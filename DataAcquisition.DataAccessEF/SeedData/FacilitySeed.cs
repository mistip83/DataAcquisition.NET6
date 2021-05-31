using System;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class FacilitySeed : IEntityTypeConfiguration<Facility>
    {
        private readonly Company _company;
        public FacilitySeed(Company company)
        {
            _company = company;
        }

        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(
                new Facility()
                {
                    FacilityId = Guid.NewGuid(),
                    FacilityName = "FacilityA",
                    CompanyId = _company.CompanyId
                });

            builder.HasData(
                new Facility()
                {
                    FacilityId = Guid.NewGuid(),
                    FacilityName = "FacilityB",
                    CompanyId = _company.CompanyId
                });
        }
    }
}
