using FisherSite.Domain;
using FisherSite.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherSite.Persistence
{
    public class FisherSiteDbContext : DbContext
    {
        private readonly string connectionString = "Server=UMITFISHER; Database=FisherSiteDb; Integrated Security=true;";

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentState> ApartmentStates { get; set; }
        public DbSet<ApartmentType> ApartmentTypes { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ApartmentConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new BlockConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ApartmentStateConfiguration());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
