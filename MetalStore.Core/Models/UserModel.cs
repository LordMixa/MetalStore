namespace MetalStore.Core.Models;

public class UserModel
{
    public Guid UserId { get; set; }
    public int PublicUserId { get; set; }
    public required string Email { get; set; }
    public required string Name { get; set; }
}
