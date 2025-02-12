using AutoMapper;
using MetalStore.Contracts.Requests;
using MetalStore.Contracts.Responses;
using MetalStore.Core.Models;
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
    public async Task<IActionResult> GetClothingItemByPublicId(string publicClothingItemId)
    {
        var clothingItemModel = await _clothingItemService.GetClothingItemByPublicIdAsync(publicClothingItemId);

        var clothingItemResponse = _mapper.Map<ClothingItemResponse>(clothingItemModel);

        return Ok(clothingItemResponse);
    }

    [HttpGet]
    public async Task<IActionResult> GetClothingItems()
    {
        var clothingItemModels = await _clothingItemService.GetClothingItemsAsync();

        var clothingItemResponses = _mapper.Map<IEnumerable<ClothingItemResponse>>(clothingItemModels);

        return Ok(clothingItemResponses);
    }

    [HttpPost]
    public async Task<IActionResult> GetClothingItemsByFilter([FromBody] ClothingItemFilter clothingItemFilter)
    {
        var clothingItemFilterModel = _mapper.Map<ClothingItemFilterModel>(clothingItemFilter);

        var clothingItemModels = await _clothingItemService.GetClothingItemsByFilterAsync(clothingItemFilterModel);

        var clothingItemResponses = _mapper.Map<IEnumerable<ClothingItemResponse>>(clothingItemModels);

        return Ok(clothingItemResponses);
    }
}
