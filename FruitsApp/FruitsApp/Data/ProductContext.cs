using Microsoft.EntityFrameworkCore;

namespace FruitsApp.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }
        public DbSet<Model.Product> Product { get;set;}
    }
}