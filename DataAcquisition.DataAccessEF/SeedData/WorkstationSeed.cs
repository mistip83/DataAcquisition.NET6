using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class WorkstationSeed : IEntityTypeConfiguration<Workstation>
    {
        public void Configure(EntityTypeBuilder<Workstation> builder)
        {
            builder.HasData(
                new Workstation()
                {
                    WorkstationId = 1,
                     WorkstationName = "Workstation1",
                     WorkstationDescription = "Lab4",
                     FacilityId = 1
                });

            builder.HasData(
                new Workstation()
                {
                    WorkstationId = 2,
                    WorkstationName = "Workstation2",
                    WorkstationDescription = "Lab4",
                    FacilityId = 1
                });

            builder.HasData(
                new Workstation()
                {
                    WorkstationId = 3,
                    WorkstationName = "Workstation3",
                    WorkstationDescription = "Lab7",
                    FacilityId = 1
                });

            builder.HasData(
                new Workstation()
                {
                    WorkstationId = 4,
                    WorkstationName = "Workstation4",
                    WorkstationDescription = "ProductionLine",
                    FacilityId = 2
                });

            builder.HasData(
                new Workstation()
                {
                    WorkstationId = 5,
                    WorkstationName = "Workstation5",
                    WorkstationDescription = "ProductionLine",
                    FacilityId = 2
                });
        }
    }
}