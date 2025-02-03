using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetalStore.Data.Entities;

[Keyless]
public class ClothingItemOrder
{
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    [ForeignKey("ClothingItem")]
    public int ClothingItemId { get; set; }
}
