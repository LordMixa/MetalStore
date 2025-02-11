using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Data.TableConfigurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(n => n.OrderId);

        builder.Property(n => n.OrderId)
               .ValueGeneratedOnAdd();

        builder.Property(n => n.PublicOrderId)
               .HasMaxLength(50);

        builder.HasOne(n => n.User)
               .WithMany(u => u.Orders)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
