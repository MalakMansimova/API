using Microsoft.EntityFrameworkCore;
using ServiceProject1.Models;

namespace ServiceProject1.DAL
{
    public class AppDbContext : DbContext
    {
      
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
    }
}
