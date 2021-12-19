using Microsoft.EntityFrameworkCore;

namespace EfCoreTutorialDotNet6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "The Hitchhiker's Guide to the Galaxy" },
                new Product { Id = 2, Name = "Ready Player One" },
                new Product { Id = 3, Name = "1984" },
                new Product { Id = 4, Name = "The Matrix Resurrections" },
                new Product { Id = 5, Name = "Diablo 2: Resurrected" },
                new Product { Id = 6, Name = "Super Nintendo Entertainment System" },
                new Product { Id = 7, Name = "Day of the Tentacle" },
                new Product { Id = 8, Name = "Back to the Future" },
                new Product { Id = 9, Name = "Toy Story" },
                new Product { Id = 10, Name = "Brave New World" }
                );
        }

        public DbSet<Product>? Products { get; set; }
    }
}
