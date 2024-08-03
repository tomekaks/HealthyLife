using HealthyLife.Application.Features.Products.Dtos;

namespace HealthyLife.Application.Features.Products.Services
{
    public interface IProductService
    {
        Task CreateAsync(CreateProductDto productDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProductDto productDto);
        Task<ProductDto> GetByIdAsync(int id);
        Task<List<ProductDto>> GetAllAsync();
    }
}
