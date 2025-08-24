using MarketPlace.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Data.DataContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "Powerful laptop with 16GB RAM",
                    Price = 750.00m,
                    ImageUrl = "images/laptop.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Textbook",
                    Description = "Calculus textbook for university",
                    Price = 40.00m,
                    ImageUrl = "images/textbook.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Description = "Wireless noise-cancelling headphones",
                    Price = 120.00m,
                    ImageUrl = "images/headphones.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 3
                }
            );
        }
    }
}
