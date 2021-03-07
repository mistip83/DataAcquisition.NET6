using DataAcquisition.Interface.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Email);

            // User has one company
            //builder.HasOne(p => p.Company)
            //    .WithMany(p => p.Users)
            //    .HasForeignKey(p => p.UserId);

            //// User has many experiments
            //builder.HasMany(p => p.Experiments)
            //    .WithOne(p => p.User)
            //    .HasForeignKey(p => p.ExperimentId);
        }
    }
}