using Microsoft.EntityFrameworkCore;

namespace FruitAPI;

class FruitDb(DbContextOptions<FruitDb> options) : DbContext(options)
{
    public DbSet<Fruit> Fruits => Set<Fruit>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Fruit>()
            .HasData(
                new Fruit { Id = 1, Name = "Apple", InStock = true },
                new Fruit { Id = 2, Name = "Banana", InStock = false },
                new Fruit { Id = 3, Name = "Orange", InStock = true }
            );
    }
}