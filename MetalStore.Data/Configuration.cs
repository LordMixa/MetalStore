using MetalStore.Data.Repositories;
using MetalStore.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MetalStore.Data;

public static class Configuration
{
    public static void Configure(IServiceCollection serviceCollection, string connectionString)
    {
        serviceCollection.AddTransient<IClothingItemRepository, ClothingItemRepository>();
        serviceCollection.AddTransient<IAuditLogRepository, AuditLogRepository>();

        serviceCollection.AddDbContext<MetalStoreContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
