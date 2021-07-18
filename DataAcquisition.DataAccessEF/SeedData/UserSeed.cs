using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User()
                {
                    Email = "muratistipliler@gmail.com",
                    Password = "25d55ad283aa400af464c76d713c07ad",
                    Name = "Murat",
                    Surname = "Istip"
                });
        }
    }
}