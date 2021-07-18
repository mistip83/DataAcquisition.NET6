﻿using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Email);

            builder.Property(p => p.Email)
                .HasMaxLength(50);

            builder.Property(p => p.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p => p.Surname)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(p=>p.DisplayName)
                .HasComputedColumnSql("[Name] + ', ' + [FirstName]");

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