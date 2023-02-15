using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Customer.Api.EntityConfiguration
{
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Models.Customer>
    {
        public void Configure(EntityTypeBuilder<Models.Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey(x => x.CustomerId);
        }
    }
}
