using AutoMapper;
using MetalStore.Core.MapperConfigurations;
using MetalStore.Core.Models;
using MetalStore.Core.Services.Interfaces;
using MetalStore.Data.Entities;
using MetalStore.Data.Repositories;
using MetalStore.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalStore.Core.Services
{
    internal class ClothingItemService : IClothingItem
    {
        private readonly IMapper _mapper;
        private readonly IClothingItemRepository _clothingItemRepository;
        public ClothingItemService(IMapper mapper, IClothingItemRepository clothingItemService)
        {
            _clothingItemRepository = clothingItemService;
            _mapper = mapper;
        }
        public async Task<ClothingItemModel?> GetClothingItemByPublicIdAsync(int publicClothingItemId)
        {
            var clothingItem = await _clothingItemRepository.GetClothingItemByPublicIdAsync(publicClothingItemId);
            return _mapper.Map<ClothingItemModel>(clothingItem);
        }
    }
}
