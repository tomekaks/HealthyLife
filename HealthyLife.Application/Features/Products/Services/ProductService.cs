using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Products.Dtos;
using HealthyLife.Application.Features.Products.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IApplicationDbContext _context;

        public ProductService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateProductDto productDto)
        {
            var product = new Product()
            {
                Name = productDto.Name,
                Calories = productDto.Calories,
                Proteins = productDto.Proteins,
                Carbs = productDto.Carbs,
                Fats = productDto.Fats,
                Fiber = productDto.Fiber,
                Price = productDto.Price,
                CreatedBy = productDto.CreatedBy
            };

            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await GetProductAsync(id);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();

            if (products is null || products.Count < 1)
            {
                return new List<ProductDto>();
            }

            var productsDtos = products.Select(product => product.ToDto()).ToList();
            return productsDtos;
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await GetProductAsync(id);
            var productDto = product.ToDto();
            return productDto;
        }

        public async Task UpdateAsync(UpdateProductDto productDto)
        {
            var product = await GetProductAsync(productDto.Id);

            product.Calories = productDto.Calories;
            product.Proteins = productDto.Proteins;
            product.Carbs = productDto.Carbs;
            product.Fats = productDto.Fats;
            product.Fiber = productDto.Fiber;
            product.Price = productDto.Price;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        private async Task<Product> GetProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id) ?? throw new Exception("Product not found");
            return product;
        }
    }
}
