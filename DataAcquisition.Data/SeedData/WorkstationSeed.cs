using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class WorkstationSeed : IEntityTypeConfiguration<Workstation>
    {
        public WorkstationSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Workstation> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}