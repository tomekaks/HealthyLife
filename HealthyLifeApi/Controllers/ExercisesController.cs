using HealthyLife.Application.Features.Exercises.Dtos;
using HealthyLife.Application.Features.Exercises.Services;
using HealthyLife.Application.Features.Products.Dtos;
using HealthyLife.Application.Features.Products.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExercisesController : BaseController
    {
        private readonly IExerciseService _exerciseService;

        public ExercisesController(IExerciseService exerciseService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _exerciseService = exerciseService;
        }


        [HttpGet]
        public async Task<ActionResult<List<ExerciseDto>>> GetAllAsync()
        {
            var exercises = await _exerciseService.GetAllAsync();
            return Ok(exercises);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ExerciseDto>> GetAsync(int id)
        {
            var exerciseDto = await _exerciseService.GetByIdAsync(id);
            return Ok(exerciseDto);
        }


        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateExerciseDto exerciseDto)
        {
            exerciseDto.CreatedBy = CurrentUserId;

            await _exerciseService.CreateAsync(exerciseDto);
            return Ok();

        }


        [HttpPut]
        public async Task UpdateAsync([FromBody] UpdateExerciseDto exerciseDto)
        {
            await _exerciseService.UpdateAsync(exerciseDto);
        }


        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
            await _exerciseService.DeleteAsync(id);
        }
    }
}
