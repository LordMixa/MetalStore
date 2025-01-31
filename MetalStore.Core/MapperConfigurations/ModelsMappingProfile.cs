using AutoMapper;
using MetalStore.Core.Models;
using MetalStore.Data.Entities;

namespace MetalStore.Core.MapperConfigurations;

public class ModelsMappingProfile:Profile
{
    public ModelsMappingProfile()
    {
        CreateMap<ClothingItem, ClothingItemModel>().ReverseMap();
        CreateMap<AuditLog, AuditLogModel>().ReverseMap();
    }
}
