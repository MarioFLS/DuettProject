using DueetAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DueetAPI.Repository
{
    public class DueetContext : DbContext
    {
        public DueetContext(DbContextOptions<DueetContext> options) : base(options) { }

        public DueetContext() { }

        public DbSet<Fruit> Fruit { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fruit>()
                .Property(f => f.Value)
                .HasPrecision(10, 2)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Fruit>()
                .Property(f => f.Tax)
                .HasPrecision(5, 2)
                .HasColumnType("decimal(5, 2)");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=DueetDB;User=SA;Password=Password12!;Encrypt=False");
            }
        }


    }
}
