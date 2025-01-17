using AutoMapper;
using MetalStore.Contracts.Responses;
using MetalStore.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MetalStore.Api.Controllers;

[ApiController]
[Route("api/clothing-items")]
public class ClothingItemController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IClothingItemService _clothingItemService;
    public ClothingItemController(IMapper mapper, IClothingItemService clothingItemService)
    {
        _clothingItemService = clothingItemService;
        _mapper = mapper;
    }

    [HttpGet("{publicClothingItemId}")]
    public async Task<IActionResult> GetClothingItemByPublicId(int publicClothingItemId)
    {
        var clothingItemModel = await _clothingItemService.GetClothingItemByPublicIdAsync(publicClothingItemId);
        var clothingItemContract = _mapper.Map<ClothingItemResponse>(clothingItemModel);

        return Ok(clothingItemContract);
    }
}
