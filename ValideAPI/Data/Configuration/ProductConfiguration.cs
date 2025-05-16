using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValideAPI.Model;

namespace ValideAPI.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductName).IsRequired(true).HasColumnType("VARCHAR(50)");

            builder.Property(x => x.Price).IsRequired(true).HasColumnType("NVARCHAR(10)");

            builder.Property(x => x.Amount).IsRequired(true).HasColumnType("NVARCHAR(5)");

            builder.Property(x => x.Register).IsRequired(true).HasColumnType("DATETIME");
            
            builder.HasIndex(x => x.ProductNumber).IsUnique();

            builder.HasOne(c => c.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
