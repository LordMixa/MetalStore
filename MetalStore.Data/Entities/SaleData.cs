namespace MetalStore.Data.Entities;

public class SaleData
{
    public int SaleDataId { get; set; }
    public int ClothingItemId { get; set; }
    public int ClothingCount { get; set; }
    public double ClothingPrice { get; set; }
    public ClothingItem? ClothingItem { get; set; }
}
