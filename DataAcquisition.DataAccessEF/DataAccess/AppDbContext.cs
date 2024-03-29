﻿using DataAcquisition.Core.Models.Entities;
using DataAcquisition.DataAccessEF.Configurations;
using DataAcquisition.DataAccessEF.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAcquisition.DataAccessEF.DataAccess;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(DbContextOptions<AppDbContext> options, IConfiguration configuration) : base(options)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration["ConnectionStrings:SqlConnectionString"], o =>
        {
            o.MigrationsAssembly("DataAcquisition.DataAccessEF");
        });
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
            
        // Apply seed data
        modelBuilder.ApplyConfiguration(new ApplicationInfoSeed());
        modelBuilder.ApplyConfiguration(new CompanySeed());
        modelBuilder.ApplyConfiguration(new FacilitySeed());
        modelBuilder.ApplyConfiguration(new WorkstationSeed());
        modelBuilder.ApplyConfiguration(new DeviceSeed());
        modelBuilder.ApplyConfiguration(new UserSeed());
    }
}