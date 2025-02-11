namespace MetalStore.Core.Models;

public class OrderModel
{
    public int OrderId { get; set; }
    public required string PublicOrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDateAndTime { get; set; }
    public IEnumerable<ClothingItemModel>? ClothingItems { get; set; }
}
