using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Data.TableConfigurations;

public class ClothingItemConfiguration : IEntityTypeConfiguration<ClothingItem>
{
    public void Configure(EntityTypeBuilder<ClothingItem> builder)
    {
        builder.HasKey(n => n.ClothingItemId);

        builder.Property(n => n.ClothingItemId)
               .ValueGeneratedOnAdd();

        builder.Property(n => n.Name)
               .HasMaxLength(30);

        builder.Property(n => n.Description)
               .HasMaxLength(255);

        builder.Property(n => n.Brand)
               .HasMaxLength(20);

        builder.HasMany(n => n.Orders)
               .WithMany(n => n.ClothingItems);
        builder.HasOne(n => n.SaleData)
               .WithOne(s => s.ClothingItem)
               .OnDelete(DeleteBehavior.Cascade); ;
    }
}