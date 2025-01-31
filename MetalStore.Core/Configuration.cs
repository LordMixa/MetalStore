using Microsoft.Extensions.DependencyInjection;
using MetalStore.Core.MapperConfigurations;
using MetalStore.Core.Services.Interfaces;
using MetalStore.Core.Services;

namespace MetalStore.Core;

public static class Configuration
{
    public static void Configure(IServiceCollection serviceCollection, string connectionString)
    {
        Data.Configuration.Configure(serviceCollection, connectionString);

        serviceCollection.AddAutoMapper(typeof(ModelsMappingProfile));

        serviceCollection.AddTransient<IClothingItemService, ClothingItemService>();
        serviceCollection.AddTransient<IAuditLogService, AuditLogService>();
    }
}
