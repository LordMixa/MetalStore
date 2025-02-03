using MetalStore.Data.Enums;

namespace MetalStore.Data.Entities;

public class ClothingItem
{
    public Guid ClothingItemId { get; set; }
    public int PublicClothingItemId { get; set; }
    public required string Name { get; set; }
    public ClothingType Type { get; set; }
    public string? Description { get; set; }
    public ClothingSize Size { get; set; }
    public string? Brand { get; set; }
    public SaleData SaleData { get; set; }
    public List<Order> Orders { get; set; }
}
