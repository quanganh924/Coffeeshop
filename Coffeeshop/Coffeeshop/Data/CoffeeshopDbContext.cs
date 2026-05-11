using Coffeeshop.Models;
using Microsoft.EntityFrameworkCore;
namespace Coffeeshop.Data
{
    public class CoffeeshopDbContext: DbContext
    {
      public CoffeeshopDbContext(DbContextOptions<CoffeeshopDbContext> options):base(options){ }
      public DbSet<Product> Products { get; set; }
    }

}

