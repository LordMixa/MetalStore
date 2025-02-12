using MetalStore.Core.Enums;

namespace MetalStore.Core.Models;

public class ClothingItemModel
{
    public int ClothingItemId { get; set; }
    public required string PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Performer { get; set; }
    public SaleDataModel? SaleData { get; set; }
}
