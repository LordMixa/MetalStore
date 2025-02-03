namespace MetalStore.Data.Entities;

public class SaleData
{
    public Guid SaleDataId { get; set; }
    public Guid ClothingItemId { get; set; }
    public int ClothingCount { get; set; }
    public int ClothingPrice { get; set; }
    public ClothingItem ClothingItem { get; set; }
}
