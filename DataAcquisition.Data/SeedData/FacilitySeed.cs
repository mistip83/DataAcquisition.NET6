using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class FacilitySeed : IEntityTypeConfiguration<Facility>
    {
        public FacilitySeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}