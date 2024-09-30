using HealthyLife.Application.Features.Supplements.Dtos;
using HealthyLife.Application.Features.Supplements.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/supplements")]
    [ApiController]
    public class SupplementsController : BaseController
    {
        private readonly ISupplementService _supplementService;
        public SupplementsController(IHttpContextAccessor contextAccessor, ISupplementService supplementService) : base(contextAccessor)
        {
            _supplementService = supplementService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SupplementDto>>> GetAllAsync()
        {
            var supplements = await _supplementService.GetAllAsync();
            return Ok(supplements);
        }

        [HttpGet]
        public async Task<ActionResult<List<SupplementDto>>> GetByUserAsync()
        {
            var supplements = await _supplementService.GetByUserAsync(CurrentUserId);
            return Ok(supplements);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SupplementDto>>> GetAsync(int id)
        {
            var supplement = await _supplementService.GetByIdAsync(id);
            return Ok(supplement);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateSupplementDto supplementDto)
        {
            supplementDto.CreatedBy = CurrentUserId;

            await _supplementService.CreateAsync(supplementDto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateSupplementDto supplementDto) 
        { 
            await _supplementService.UpdateAsync(supplementDto); 
            return Ok(); 
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _supplementService.DeleteAsync(id); 
            return Ok();
        }
    }
}
