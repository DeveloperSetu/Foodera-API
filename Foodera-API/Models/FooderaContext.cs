using Microsoft.EntityFrameworkCore;

namespace Foodera_API.Models
{
    public class FooderaContext:DbContext
    {
        public FooderaContext(DbContextOptions<FooderaContext> options) : base(options) { }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Categorie { get; set; }
        public DbSet<Order> Order { get; set; }
    }
}
