using HealthyLife.Application.Features.Products.Dtos;
using HealthyLife.Application.Features.Products.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService, IHttpContextAccessor httpContextAccessor) : base(httpContextAccessor)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> Get()
        {
            var products = await _productService.GetAllAsync();
            return Ok(products);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> Get(int id)
        {
            var productDto = await _productService.GetByIdAsync(id);
            return Ok(productDto);
        }


        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateProductDto productDto)
        {
            await _productService.AddAsync(productDto);
            return Ok();

        }


        [HttpPut]
        public async Task Put([FromBody] UpdateProductDto productDto)
        {
            await _productService.UpdateAsync(productDto);
        }

        
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productService.DeleteAsync(id);
        }
    }
}
