using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class FacilitySeed : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasData(
                new Facility()
                {
                    FacilityId = 1,
                    FacilityName = "FacilityA",
                    Address = "V94 H9FF - Limerick",
                    Employees = 65
                });

            builder.HasData(
                new Facility()
                {
                    FacilityId = 2,
                    FacilityName = "FacilityB",
                    Address = "V35 S7BN - Cork",
                    Employees = 140
                });
        }
    }
}
