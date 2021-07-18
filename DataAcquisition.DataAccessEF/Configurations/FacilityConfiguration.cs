﻿using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAcquisition.DataAccessEF.Configurations
{
    public class FacilityConfiguration : IEntityTypeConfiguration<Facility>
    {
        public void Configure(EntityTypeBuilder<Facility> builder)
        {
            builder.HasKey(x => x.FacilityId);

            builder.Property(p => p.FacilityId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Address)
                .HasMaxLength(250);

            builder.Property(p => p.FacilityName)
                .HasMaxLength(100)
                .IsRequired();

            // Facility has one company
            //builder.HasOne(p => p.Company)
            //    .WithMany(p => p.Facilities)
            //    .HasForeignKey(p => p.FacilityId);

            //// Facility has many workstation
            //builder.HasMany((p => p.WorkStations))
            //    .WithOne(p => p.Facility)
            //    .HasForeignKey(p => p.WorkstationId);
        }
    }
}