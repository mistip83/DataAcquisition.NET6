﻿using System;
using DataAcquisition.DataAccessEF.Configurations;
using DataAcquisition.DataAccessEF.SeedData;
using DataAcquisition.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.DataAccessEF.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public DbSet<Experiment> Experiment { get; set; }
        public DbSet<Facility> Facility { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Workstation> Workstation { get; set; }
        public DbSet<Device> Device { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations
            modelBuilder.ApplyConfiguration(new ApplicationInfoConfiguration());
            modelBuilder.ApplyConfiguration(new ExperimentConfiguration());
            modelBuilder.ApplyConfiguration(new DeviceConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WorkstationConfiguration());

            var company = new Company()
            {
                CompanyId = Guid.NewGuid(),
                CompanyName = "AcmeCompany"
            };

            // Apply seed data
            modelBuilder.ApplyConfiguration(new ApplicationInfoSeed());
            modelBuilder.ApplyConfiguration(new CompanySeed(company));
            modelBuilder.ApplyConfiguration(new UserSeed(company));
        }
    }
}
