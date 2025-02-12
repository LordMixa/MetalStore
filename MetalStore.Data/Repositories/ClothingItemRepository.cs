using MetalStore.Data.Entities;
using MetalStore.Data.Extensions;
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
        var clothingItem = await _metalStoreContext.ClothingItems
            .Include(c => c.SaleData)
            .FirstOrDefaultAsync(
            x => x.PublicClothingItemId == publicClothingItemId);

        return clothingItem;
    }

    public async Task<IEnumerable<ClothingItem>?> GetClothingItemsAsync()
    {
        var clothingItems = await _metalStoreContext.ClothingItems.ToListAsync();

        return clothingItems;
    }

    public async Task<IEnumerable<ClothingItem>?> GetClothingItemsByFilterAsync(ClothingItemFilter clothingItemFilter)
    {
        var query = _metalStoreContext.ClothingItems
                 .Include(c => c.SaleData)
                 .AsQueryable();

        query = query.FilterByPerformers(clothingItemFilter.Performers)
                     .FilterBySizes(clothingItemFilter.Sizes)
                     .FilterByTypes(clothingItemFilter.Types)
                     .FilterByName(clothingItemFilter.Name)
                     .FilterByPublicClothingItemId(clothingItemFilter.PublicClothingItemId)
                     .FilterByMinPrice(clothingItemFilter.MinPrice)
                     .FilterByMaxPrice(clothingItemFilter.MaxPrice)
                     .FilterByAvailability(clothingItemFilter.IsAvailable);

        var clothingItems = await query.ToListAsync();

        return clothingItems;
    }

    public virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _metalStoreContext?.Dispose();
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
