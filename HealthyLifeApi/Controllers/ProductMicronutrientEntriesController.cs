using HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.ProductMicronutrientEntries.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/product-micronutrient-entries")]
    [ApiController]
    public class ProductMicronutrientEntriesController : BaseController
    {
        private readonly IProductMicronutrientEntryService _productMicronutrientEntryService;
        public ProductMicronutrientEntriesController(IHttpContextAccessor contextAccessor, 
            IProductMicronutrientEntryService productMicronutrientEntryService) : 
            base(contextAccessor)
        {
            _productMicronutrientEntryService = productMicronutrientEntryService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<ProductMicronutrientEntryDto>>> GetAsync(int id)
        {
            var supplement = await _productMicronutrientEntryService.GetByIdAsync(id);
            return Ok(supplement);
        }

        [HttpPost]
        public async Task<ActionResult> CreateAsync([FromBody] CreateProductMicronutrientEntryDto productMicronutrientEntryDto)
        {
            await _productMicronutrientEntryService.CreateAsync(productMicronutrientEntryDto);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> UpdateAsync([FromBody] UpdateProductMicronutrientEntryDto productMicronutrientEntryDto)
        {
            await _productMicronutrientEntryService.UpdateAsync(productMicronutrientEntryDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _productMicronutrientEntryService.DeleteAsync(id);
            return Ok();
        }
    }
}
