using System;
using System.Collections.Generic;
using DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.Data.SeedData
{
    public class OrganizationSeed : IEntityTypeConfiguration<Organization>
    {
        private readonly ICollection<User> _users;
        public OrganizationSeed(ICollection<User> user)
        {
            _users = user;
        }

        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasData(new Organization
            {
                OrganizationId = new Guid(),
                OrganizationName = "AcmeCompany",
                Users = _users
            });
        }
    }
}