using MetalStore.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Data;

public class MetalStoreContext : DbContext
{
    public MetalStoreContext(DbContextOptions<MetalStoreContext> options) : base(options)
    {
    }

    public DbSet<ClothingItem> ClothingItems { get; set; }
}