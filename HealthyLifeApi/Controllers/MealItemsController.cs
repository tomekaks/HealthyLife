using HealthyLife.Application.Features.MealItems.Dtos;
using HealthyLife.Application.Features.MealItems.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealItemsController : BaseController
    {
        private readonly IMealItemService _mealItemService;
        public MealItemsController(IHttpContextAccessor contextAccessor, IMealItemService mealItemService) : base(contextAccessor)
        {
            _mealItemService = mealItemService;
        }

        [HttpGet("/getall/{mealId}")]
        public async Task<ActionResult<List<MealItemDto>>> GetAllAsync(int mealId)
        {
            var mealItems = await _mealItemService.GetAllAsync(mealId);
            return Ok(mealItems);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MealItemDto>> GetAsync(int id)
        {
            var mealItemDto = await _mealItemService.GetByIdAsync(id);
            return Ok(mealItemDto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateMealItemDto mealItemDto)
        {
            await _mealItemService.CreateAsync(mealItemDto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateMealItemDto mealItemDto)
        {
            await _mealItemService.UpdateAsync(mealItemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _mealItemService.DeleteAsync(id);
            return NoContent();
        }
    }
}
