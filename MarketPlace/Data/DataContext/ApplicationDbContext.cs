using MarketPlace.Data.Entities;
using MarketPlace.Models;
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
        public DbSet<Order> Orders { get; set; }

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
                },
                new Product
                {
                    Id = 4,
                    Name = "Gaming Laptop",
                    Description = "High-performance laptop with RTX graphics",
                    Price = 1500.00m,
                    ImageUrl = "images/laptop.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 1
                },
                new Product
                {
                    Id = 5,
                    Name = "Smartphone",
                    Description = "Latest 5G smartphone with OLED display",
                    Price = 899.99m,
                    ImageUrl = "images/smartphone.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 2
                },
                new Product
                {
                    Id = 6,
                    Name = "Bluetooth Speaker",
                    Description = "Portable waterproof Bluetooth speaker",
                    Price = 75.50m,
                    ImageUrl = "images/speaker.png",
                    Status = "Available",
                    DatePosted = DateTime.UtcNow,
                    Category = 3
                }

            );
        }
    }
}
