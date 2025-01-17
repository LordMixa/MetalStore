using MetalStore.Core.Enums;

namespace MetalStore.Core.Models;

public class ClothingItemModel
{
    public Guid ClothingItemId { get; set; }
    public int PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Brand { get; set; }
}
