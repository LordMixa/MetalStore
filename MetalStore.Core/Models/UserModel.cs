namespace MetalStore.Core.Models;

public class UserModel
{
    public int UserId { get; set; }
    public required string PublicUserId { get; set; }
    public required string Email { get; set; }
    public required string Name { get; set; }
    public IEnumerable<OrderModel>? Orders { get; }
}
