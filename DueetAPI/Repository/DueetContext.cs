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

            modelBuilder.Entity<Fruit>().HasData(
                new Fruit() { Id = 1, Name = "Maça", Description = "Maçã fresquinha, direto do pomar para a sua mesa!", Value = 1.45m, Tax = 20.3m },
                new Fruit() { Id = 2, Name = "Banana", Description = "Banana madura e doce, perfeita para lanches e sobremesas.", Value = 2.35m, Tax = 18.5m },
                new Fruit() { Id = 3, Name = "Morango", Description = "Morangos vermelhos e suculentos, ideais para saladas e doces.", Value = 3.15m, Tax = 22.7m },
                new Fruit() { Id = 4, Name = "Pera", Description = "Pera fresca e crocante, perfeita para comer ao natural ou em saladas.", Value = 1.95m, Tax = 21.2m },
                new Fruit() { Id = 5, Name = "Laranja", Description = "Laranjas suculentas e doces, ricas em vitamina C.", Value = 1.85m, Tax = 20.5m },
                new Fruit() { Id = 6, Name = "Abacaxi", Description = "Abacaxi fresco e doce, ideal para sucos e sobremesas.", Value = 4.25m, Tax = 26.8m },
                new Fruit() { Id = 7, Name = "Uva", Description = "Uvas maduras e saborosas, perfeitas para comer ao natural ou em sobremesas.", Value = 3.95m, Tax = 25.4m },
                new Fruit() { Id = 8, Name = "Manga", Description = "Manga doce e suculenta, ideal para sucos e sobremesas.", Value = 2.75m, Tax = 19.8m },
                new Fruit() { Id = 9, Name = "Kiwi", Description = "Kiwi fresco e ácido, rico em vitamina C e ideal para saladas.", Value = 2.15m, Tax = 17.6m },
                new Fruit() { Id = 10, Name = "Abacaxi", Description = "Abacaxi tropical, suculento e doce, perfeito para o verão!", Value = 4.99m, Tax = 15.8m }
                );
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=127.0.0.1;Database=DueetDB;User=SA;Password=Password12!;Encrypt=False");
            }
        }


    }
}
