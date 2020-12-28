using System;
using System.Security.Cryptography;
using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
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
                new User
                {
                    UserId = new Guid(),
                    Password = new MD5CryptoServiceProvider().ToString(),
                    UserName = "Murat",
                    Email = "acmeCompany@acme.com",
                    Company = _company
                });
        }
    }
}