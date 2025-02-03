using System.ComponentModel.DataAnnotations.Schema;

namespace MetalStore.Core.Models;

public class OrderModel
{
    public Guid OrderId { get; set; }
    public int PublicOrderId { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
}
