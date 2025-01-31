using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

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
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}