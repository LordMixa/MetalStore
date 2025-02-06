namespace MetalStore.Data.Entities;

public class User
{
    public int UserId { get; set; }
    public required string PublicUserId { get; set; }
    public required string Email { get; set; }
    public required string Name { get; set; }
    public IEnumerable<Order>? Orders { get; }
}
