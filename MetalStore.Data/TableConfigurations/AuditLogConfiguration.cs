using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetalStore.Data.TableConfigurations;

public class AuditLogConfiguration : IEntityTypeConfiguration<AuditLog>
{
    public void Configure(EntityTypeBuilder<AuditLog> builder)
    {
        builder.HasKey(n => n.AuditLogId);

        builder.Property(n => n.AuditLogId)
               .ValueGeneratedOnAdd();

        builder.Property(n => n.HttpMethod)
               .HasMaxLength(255);

        builder.Property(n => n.Url)
               .HasMaxLength(255);
    }
}
