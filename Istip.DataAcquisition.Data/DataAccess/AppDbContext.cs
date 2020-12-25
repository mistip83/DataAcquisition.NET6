using Istip.DataAcquisition.Core.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Istip.DataAcquisition.Data.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AppConfiguration> AppConfigurations { get; set; }
        public DbSet<ApplicationInfo> ApplicationInfo { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Experiment> Experiments { get; set; }
        public DbSet<Facility> Facilitys { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Workstation> Workstations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
