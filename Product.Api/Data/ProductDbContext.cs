using Microsoft.EntityFrameworkCore;
using Product.Api.EntityConfiguration;

namespace Product.Api.Data
{
    public class ProductDbContext : DbContext
    {
        public DbSet<Models.Product> Products { get; set; }

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
        }
    }
}
