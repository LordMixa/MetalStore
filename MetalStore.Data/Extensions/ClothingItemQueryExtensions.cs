using MetalStore.Data.Entities;
using MetalStore.Data.Enums;

namespace MetalStore.Data.Extensions;

public static class ClothingItemQueryExtensions
{
    public static IQueryable<ClothingItem> FilterByPerformers(this IQueryable<ClothingItem> query, IEnumerable<string> performers)
    {
        return performers.Any() ? query.Where(c => performers.Contains(c.Performer)) : query;
    }

    public static IQueryable<ClothingItem> FilterBySizes(this IQueryable<ClothingItem> query, IEnumerable<ClothingSize> sizes)
    {
        return sizes.Any() ? query.Where(c => sizes.Contains(c.Size)) : query;
    }

    public static IQueryable<ClothingItem> FilterByTypes(this IQueryable<ClothingItem> query, IEnumerable<ClothingType> types)
    {
        return types.Any() ? query.Where(c => types.Contains(c.Type)) : query;
    }

    public static IQueryable<ClothingItem> FilterByName(this IQueryable<ClothingItem> query, string? name)
    {
        return !string.IsNullOrEmpty(name) ? query.Where(c => c.Name.Contains(name)) : query;
    }

    public static IQueryable<ClothingItem> FilterByPublicClothingItemId(this IQueryable<ClothingItem> query, string? publicClothingItemId)
    {
        return !string.IsNullOrEmpty(publicClothingItemId) ? query.Where(c => c.PublicClothingItemId == publicClothingItemId) : query;
    }

    public static IQueryable<ClothingItem> FilterByMinPrice(this IQueryable<ClothingItem> query, double minPrice)
    {
        return minPrice != 0 ? query.Where(c => c.SaleData != null && c.SaleData.ClothingPrice >= minPrice) : query;
    }

    public static IQueryable<ClothingItem> FilterByMaxPrice(this IQueryable<ClothingItem> query, double maxPrice)
    {
        return maxPrice != 0 ? query.Where(c => c.SaleData != null && c.SaleData.ClothingPrice <= maxPrice) : query;
    }

    public static IQueryable<ClothingItem> FilterByAvailability(this IQueryable<ClothingItem> query, bool isAvailable)
    {
        return isAvailable ? query.Where(c => c.SaleData != null && c.SaleData.ClothingCount > 0) : query;
    }
}
