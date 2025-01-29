using HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.SupplementMicronutrientEntries.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/supplement-micronutrient-entries")]
    [ApiController]
    public class SupplementMicronutrientEntriesController : BaseController
    {
        private readonly ISupplementMicronutrientEntryService _supplementMicronutrientEntryService;
        public SupplementMicronutrientEntriesController(IHttpContextAccessor contextAccessor, 
            ISupplementMicronutrientEntryService supplementMicronutrientEntryService) : 
            base(contextAccessor)
        {
            _supplementMicronutrientEntryService = supplementMicronutrientEntryService;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<List<SupplementMicronutrientEntryDto>>> GetAsync(int id)
        {
            var supplement = await _supplementMicronutrientEntryService.GetByIdAsync(id);
            return Ok(supplement);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto)
        {
            await _supplementMicronutrientEntryService.CreateAsync(supplementMicronutrientEntryDto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto)
        {
            await _supplementMicronutrientEntryService.UpdateAsync(supplementMicronutrientEntryDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _supplementMicronutrientEntryService.DeleteAsync(id);
            return Ok();
        }
    }
}
