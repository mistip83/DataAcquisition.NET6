using System.Security.Cryptography.X509Certificates;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        private readonly Company _company;

        public UserSeed(Company company)
        {
            _company = company;
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User()
                {
                    Email = "muratistipliler@gmail.com",
                    Password = "25d55ad283aa400af464c76d713c07ad",
                    Name = "Murat",
                    Surname = "Istipliler",
                    CompanyId = _company.CompanyId
                });
        }
    }
}