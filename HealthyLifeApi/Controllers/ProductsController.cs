using HealthyLife.Application.Features.Products.Dtos;
using HealthyLife.Application.Features.Products.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HealthyLifeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
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
            var product = await _productService.GetByIdAsync(id);
            return Ok(product);
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
