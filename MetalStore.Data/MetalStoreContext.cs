using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Data;

public class MetalStoreContext : DbContext
{
    public MetalStoreContext(DbContextOptions<MetalStoreContext> options) : base(options)
    {
    }

    public DbSet<ClothingItem> ClothingItems { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuditLog>()
            .HasKey(n => n.AuditLogId); 
        modelBuilder.Entity<AuditLog>()
            .Property(n => n.AuditLogId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<AuditLog>()
           .Property(n => n.HttpMethod)
           .HasMaxLength(255);
        modelBuilder.Entity<AuditLog>()
           .Property(n => n.Url)
           .HasMaxLength(255);
        modelBuilder.Entity<ClothingItem>()
            .HasKey(n => n.ClothingItemId);
        modelBuilder.Entity<ClothingItem>()
            .Property(n => n.ClothingItemId)
            .ValueGeneratedOnAdd();
        modelBuilder.Entity<ClothingItem>()
           .Property(n => n.Name)
           .HasMaxLength(30);
        modelBuilder.Entity<ClothingItem>()
           .Property(n => n.Description)
           .HasMaxLength(255); 
        modelBuilder.Entity<ClothingItem>()
           .Property(n => n.Brand)
           .HasMaxLength(20);
    }
}