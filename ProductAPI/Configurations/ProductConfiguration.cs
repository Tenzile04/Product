using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductAPI.Entities;

namespace ProductAPI.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(200);
            builder.Property(x=>x.SalePrice).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(x => x.CostPrice).IsRequired().HasColumnType("decimal(18,2)");
        }
    }
}
