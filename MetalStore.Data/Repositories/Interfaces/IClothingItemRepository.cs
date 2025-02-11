using MetalStore.Data.Entities;

namespace MetalStore.Data.Repositories.Interfaces;

public interface IClothingItemRepository
{
    public Task<ClothingItem?> GetClothingItemByPublicIdAsync(string publicClothingItemId);
    public Task<IEnumerable<ClothingItem>?> GetClothingItemsAsync();
    public Task<IEnumerable<ClothingItem>?> GetClothingItemsByFilterAsync(ClothingItemFilter clothingItemFilter);
}