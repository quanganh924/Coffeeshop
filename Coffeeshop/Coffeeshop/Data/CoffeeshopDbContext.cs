using Coffeeshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Coffeeshop.Data
{
    public class CoffeeshopDbContext : DbContext
    {
        public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options)
            : base(options)
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
                    Name = "America",
                    Price = 25,
                    Detail = "Name product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },

                new Product
                {
                    Id = 2,
                    Name = "Vietnam",
                    Price = 20,
                    Detail = "Vietnamese product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                },

                new Product
                {
                    Id = 3,
                    Name = "United Kingdom",
                    Price = 15,
                    Detail = "UK product",
                    ImageUrl = "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp"
                }
            );
        }
    }
}