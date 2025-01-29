using HealthyLife.Application.Features.Micronutrients.Dtos;
using HealthyLife.Application.Features.Micronutrients.Services;
using HealthyLife.Application.Features.Products.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/micronutrients")]
    [ApiController]
    public class MicronutrientsController : BaseController
    {
        private readonly IMicronutrientService _micronutrientService;
        public MicronutrientsController(IHttpContextAccessor contextAccessor, IMicronutrientService micronutrientService) : 
                                        base(contextAccessor)
        {
            _micronutrientService = micronutrientService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MicronutrientDto>>> GetAllAsync()
        {
            var micronutrients = await _micronutrientService.GetAllAsync();
            return Ok(micronutrients);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MicronutrientDto>> GetAsync(int id)
        {
            var micronutrient = await _micronutrientService.GetByIdAsync(id);
            return Ok(micronutrient);
        }
    }
}
