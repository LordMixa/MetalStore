using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetalStore.Core.Enums;

namespace MetalStore.Core.Models
{
    internal class ClothingItemModel
    {
        public Guid ClothingItemId { get; set; }
        public int PublicClothingItemId { get; set; }
        public required string Name { get; set; }
        public ClothingType Type { get; set; }
        public string? Description { get; set; }
        public ClothingSize Size { get; set; }
        public string? Brand { get; set; }
    }
}
