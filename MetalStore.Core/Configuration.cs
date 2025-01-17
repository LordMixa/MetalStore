using MetalStore.Data.Repositories.Interfaces;
using MetalStore.Data.Repositories;
using MetalStore.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Core;
public static class Configuration
{
    public static void Configure(IServiceCollection serviceCollection, string connectionString)
    {
        serviceCollection.AddTransient<IClothingItemRepository, ClothingItemRepository>();

        serviceCollection.AddDbContext<MetalStoreContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
