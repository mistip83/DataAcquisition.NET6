using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class DeviceSeed : IEntityTypeConfiguration<Device>
    {
        public DeviceSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Device> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}