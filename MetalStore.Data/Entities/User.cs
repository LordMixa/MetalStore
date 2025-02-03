namespace MetalStore.Data.Entities;

public class User
{
    public int UserId { get; set; }
    public string PublicUserId { get; set; }
    public required string Email { get; set; }
    public required string Name { get; set; }
    public ICollection<Order>? Orders { get; }
}
