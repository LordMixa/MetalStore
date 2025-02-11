namespace MetalStore.Data.Entities;

public class Order
{
    public int OrderId { get; set; }
    public required string PublicOrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDateAndTimed { get; set; }
    public User User { get; set; }
    public IEnumerable<ClothingItem> ClothingItems { get; set; }
}
