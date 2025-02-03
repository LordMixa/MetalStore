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
    public DbSet<Order> Orders { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<SaleData> SaleData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}