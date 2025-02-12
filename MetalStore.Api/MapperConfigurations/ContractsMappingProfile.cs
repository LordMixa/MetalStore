using AutoMapper;
using MetalStore.Contracts.Requests;
using MetalStore.Contracts.Responses;
using MetalStore.Core.Models;

namespace MetalStore.Api.MapperConfigurations;

public class ContractsMappingProfile : Profile
{
    public ContractsMappingProfile()
    {
        CreateMap<ClothingItemModel, ClothingItemResponse>();
        CreateMap<ClothingItemFilter, ClothingItemFilterModel>();
        CreateMap<SaleDataModel, SaleDataResponse>();
    }
}
