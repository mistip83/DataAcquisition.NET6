using System;
using System.Collections.Generic;
using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class CompanySeed : IEntityTypeConfiguration<Company>
    {
        private readonly ICollection<User> _users;
        public CompanySeed(ICollection<User> user)
        {
            _users = user;
        }

        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(new Company
            {
                CompanyId = new Guid(),
                CompanyName = "AcmeCompany",
                Users = _users
            });
        }
    }
}