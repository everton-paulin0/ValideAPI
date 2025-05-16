using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ValideAPI.Model;

namespace ValideAPI.Data.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CategoryName).IsRequired(true).HasColumnType("VARCHAR(50)");

            builder.Property(x => x.CategoryNumber).IsRequired(true).HasColumnType("NVARCHAR(5)");

            builder.Property(x => x.Description).IsRequired(true).HasColumnType("VARCHAR(100)");

            builder.HasIndex(x => x.CategoryNumber).IsUnique();

            builder.HasMany(c => c.Products)
                .WithOne(c => c.Category)                
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
