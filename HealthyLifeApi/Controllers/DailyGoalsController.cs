using HealthyLife.Application.Features.DailyGoals.Dtos;
using HealthyLife.Application.Features.DailyGoals.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/daily-goals")]
    [ApiController]
    public class DailyGoalsController : BaseController
    {
        private readonly IDailyGoalService _dailyGoalService;
        public DailyGoalsController(IHttpContextAccessor contextAccessor, IDailyGoalService dailyGoalService) : base(contextAccessor)
        {
            _dailyGoalService = dailyGoalService;
        }

        [HttpGet]
        public async Task<ActionResult<DailyGoalDto>> GetAsync()
        {
            var dailyGoal = await _dailyGoalService.GetAsync(CurrentUserId);
            return Ok(dailyGoal);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateDailyGoalDto dailyGoalDto)
        {
            await _dailyGoalService.UpdateAsync(dailyGoalDto);
            return NoContent();
        }
    }
}
