using MetalStore.Core.Models;

namespace MetalStore.Core.Services.Interfaces;

public interface IClothingItem
{
    public Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(int publicClothingItemId);
}
