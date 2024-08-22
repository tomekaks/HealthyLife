using HealthyLife.Application.Features.Workouts.Dtos;
using HealthyLife.Application.Features.Workouts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/workouts")]
    [ApiController]
    public class WorkoutsController : BaseController
    {
        private readonly IWorkoutService _workoutService;

        public WorkoutsController(IWorkoutService workoutService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _workoutService = workoutService;
        }

        [HttpGet("get-all/{dailySumId}")]
        public async Task<ActionResult<List<WorkoutDto>>> GetAllAsync(int dailySumId)
        {
            var workouts = await _workoutService.GetAllAsync(dailySumId);
            return Ok(workouts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutDto>> GetAsync(int id)
        {
            var workoutDto = await _workoutService.GetByIdAsync(id);
            return Ok(workoutDto);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateWorkoutDto workoutDto)
        {
            await _workoutService.CreateAsync(workoutDto);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] UpdateWorkoutDto workoutDto)
        {
            await _workoutService.UpdateAsync(workoutDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _workoutService.DeleteAsync(id);
            return NoContent();
        }
    }
}
