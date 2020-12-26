using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class ExperimentSeed : IEntityTypeConfiguration<Experiment>
    {
        public ExperimentSeed()
        {
            
        }

        public void Configure(EntityTypeBuilder<Experiment> builder)
        {
            throw new System.NotImplementedException();
        }
    }
}