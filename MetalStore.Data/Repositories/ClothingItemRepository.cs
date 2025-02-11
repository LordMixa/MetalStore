using MetalStore.Data.Entities;
using MetalStore.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MetalStore.Data.Repositories;

public class ClothingItemRepository : IClothingItemRepository, IDisposable
{
    private readonly MetalStoreContext _metalStoreContext;
    private bool _disposed = false;

    public ClothingItemRepository(MetalStoreContext metalStoreContext)
    {
        _metalStoreContext = metalStoreContext;
    }

    public async Task<ClothingItem?> GetClothingItemByPublicIdAsync(string publicClothingItemId)
    {
        var clothingItem = await _metalStoreContext.ClothingItems.FirstOrDefaultAsync(
            x => x.PublicClothingItemId == publicClothingItemId);

        return clothingItem;
    }

    public virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _metalStoreContext.Dispose();
            }
            _disposed = true;
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
