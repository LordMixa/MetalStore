using MetalStore.Data.Enums;

namespace MetalStore.Data.Entities;

public class ClothingItem
{
    public int ClothingItemId { get; set; }
    public required string PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Performer { get; set; }
    public SaleData? SaleData { get; set; }
    public IEnumerable<Order>? Orders { get; set; }
}
