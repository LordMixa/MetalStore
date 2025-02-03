namespace MetalStore.Data.Entities;

public class Order
{
    public int OrderId { get; set; }
    public string PublicOrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public User User { get; set; }
    public IEnumerable<ClothingItem> ClothingItems { get; set; }
}
