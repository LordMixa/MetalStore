using MetalStore.Core.Models;

namespace MetalStore.Core.Services.Interfaces;

public interface IClothingItemService
{
    public Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(string publicClothingItemId);
    public Task<IEnumerable<ClothingItemModel>?> GetClothingItemsAsync();
    public Task<IEnumerable<ClothingItemModel>?> GetClothingItemsByFilterAsync(ClothingItemFilterModel clothingItemFilterModel);
}
