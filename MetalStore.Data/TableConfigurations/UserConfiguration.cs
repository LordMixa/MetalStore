using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetalStore.Data.TableConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(n => n.UserId);

        builder.Property(n => n.UserId)
               .ValueGeneratedOnAdd();

        builder.Property(n => n.PublicUserId)
               .HasMaxLength(50);

        builder.Property(n => n.Name)
               .HasMaxLength(30);

        builder.Property(n => n.Email)
               .HasMaxLength(100);
    }
}
