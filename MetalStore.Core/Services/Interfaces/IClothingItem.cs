using MetalStore.Core.Models;
using MetalStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalStore.Core.Services.Interfaces
{
    internal interface IClothingItem
    {
        public Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(int publicClothingItemId);

    }
}
