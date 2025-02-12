namespace MetalStore.Contracts.Responses;

public class SaleDataResponse
{
    public int SaleDataId { get; set; }
    public int ClothingItemId { get; set; }
    public int ClothingCount { get; set; }
    public double ClothingPrice { get; set; }
}
