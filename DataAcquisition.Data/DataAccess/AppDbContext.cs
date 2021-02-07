using DataAcquisition.Core.Models.Entities;
using DataAcquisition.Data.Configurations;
using DataAcquisition.Data.SeedData;
using Microsoft.EntityFrameworkCore;

namespace DataAcquisition.Data.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Facility> Facilitys { get; set; }
        public DbSet<Company> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workstation> Workstations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply configurations
            modelBuilder.ApplyConfiguration(new ApplicationInfoConfiguration());
            modelBuilder.ApplyConfiguration(new ExperimentConfiguration());
            modelBuilder.ApplyConfiguration(new FacilityConfiguration());
            modelBuilder.ApplyConfiguration(new OrganizationConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WorkstationConfiguration());

            // Apply seed data
            modelBuilder.ApplyConfiguration(new ApplicationInfoSeed());
        }
    }
}
