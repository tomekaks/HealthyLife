using HealthyLife.Application.Features.Meals.Dtos;
using HealthyLife.Application.Features.Meals.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealsController : BaseController
    {
        private readonly IMealService _mealService;

        public MealsController(IMealService mealService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _mealService = mealService;
        }

        [HttpGet("/getall/{dailySumId}")]
        public async Task<ActionResult<List<MealDto>>> GetAllAsync(int dailySumId)
        {
            var meals = await _mealService.GetAllAsync(dailySumId);
            return Ok(meals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MealDto>> GetAsync(int id)
        {
            var mealDto = await _mealService.GetByIdAsync(id);
            return Ok(mealDto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateMealDto mealDto)
        {
            await _mealService.CreateAsync(mealDto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateMealDto mealDto)
        {
            await _mealService.UpdateAsync(mealDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _mealService.DeleteAsync(id);
            return NoContent();
        }
    }
}
