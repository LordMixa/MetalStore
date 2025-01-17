using AutoMapper;
using MetalStore.Core.Models;
using MetalStore.Core.Services.Interfaces;
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

    public async Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(int publicClothingItemId)
    {
        var clothingItem = await _clothingItemRepository.GetClothingItemByPublicIdAsync(publicClothingItemId);

        return _mapper.Map<ClothingItemModel>(clothingItem);
    }
}
