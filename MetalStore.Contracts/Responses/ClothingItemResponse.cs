using MetalStore.Contracts.Enums;

namespace MetalStore.Contracts.Responses;

public class ClothingItemResponse
{
    public Guid ClothingItemId { get; set; }
    public int PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Brand { get; set; }
}
