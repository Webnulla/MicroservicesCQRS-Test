using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Product.Api.EntityConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Models.Product>
    {
        public void Configure(EntityTypeBuilder<Models.Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.ProductId);
        }
    }
}
