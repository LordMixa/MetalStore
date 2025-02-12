using MetalStore.Core.Enums;

namespace MetalStore.Core.Models;

public class ClothingItemFilterModel
{
    public string? PublicClothingItemId { get; set; }
    public string? Name { get; set; }
    public IEnumerable<ClothingType> Types { get; set; } = new List<ClothingType>();
    public IEnumerable<ClothingSize> Sizes { get; set; } = new List<ClothingSize>();
    public IEnumerable<string> Performers { get; set; } = new List<string>();
    public int MinPrice { get; set; }
    public int MaxPrice { get; set; }
    public bool IsAvailable { get; set; } = false;
}
