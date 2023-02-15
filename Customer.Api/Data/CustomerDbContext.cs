using Customer.Api.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Customer.Api.Data
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Models.Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
        }
    }
}
