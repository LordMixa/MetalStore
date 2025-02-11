using MetalStore.Contracts.Enums;

namespace MetalStore.Contracts.Responses;

public class ClothingItemResponse
{
    public int ClothingItemId { get; set; }
    public required string PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Performer { get; set; }
    public SaleDataResponse? SaleData { get; set; }
}
