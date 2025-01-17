using MetalStore.Data.Entities;

namespace MetalStore.Data.Repositories.Interfaces;

public interface IClothingItemRepository
{
    public Task<ClothingItem?> GetClothingItemByPublicIdAsync(int publicClothingItemId);
}