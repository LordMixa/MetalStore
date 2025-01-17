using AutoMapper;
using MetalStore.Core.Models;
using MetalStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalStore.Core.MapperConfigurations
{
    public class ModelsMappingProfile:Profile
    {
        public ModelsMappingProfile()
        {
            CreateMap<ClothingItem, ClothingItemModel>();
            CreateMap<ClothingItem, ClothingItemModel>().ReverseMap();
        }
    }
}
