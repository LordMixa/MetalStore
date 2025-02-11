using AutoMapper;
using MetalStore.Core.Models;
using MetalStore.Core.Services.Interfaces;
using MetalStore.Data.Entities;
using MetalStore.Data.Repositories.Interfaces;

namespace MetalStore.Core.Services;

public class ClothingItemService : IClothingItemService
{
    private readonly IMapper _mapper;
    private readonly IClothingItemRepository _clothingItemRepository;

    public ClothingItemService(IMapper mapper, IClothingItemRepository clothingItemRepository)
    {
        _clothingItemRepository = clothingItemRepository;
        _mapper = mapper;
    }

    public async Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(string publicClothingItemId)
    {
        var clothingItem = await _clothingItemRepository.GetClothingItemByPublicIdAsync(publicClothingItemId);

        var clothingItemModel = _mapper.Map<ClothingItemModel>(clothingItem);

        return clothingItemModel;
    }

    public async Task<IEnumerable<ClothingItemModel>?> GetClothingItemsAsync()
    {
        var clothingItems = await _clothingItemRepository.GetClothingItemsAsync();

        var clothingItemModels = _mapper.Map<IEnumerable<ClothingItemModel>>(clothingItems);

        return clothingItemModels;
    }

    public async Task<IEnumerable<ClothingItemModel>?> GetClothingItemsByFilterAsync(ClothingItemFilterModel clothingItemFilterModel)
    {
        var clothingItemFilter = _mapper.Map<ClothingItemFilter>(clothingItemFilterModel);

        var clothingItems = await _clothingItemRepository.GetClothingItemsByFilterAsync(clothingItemFilter);

        var clothingItemModels = _mapper.Map<IEnumerable<ClothingItemModel>>(clothingItems);

        return clothingItemModels;
    }
}
