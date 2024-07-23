using HealthyLife.Application.Features.Products.Dtos;

namespace HealthyLife.Application.Features.Products.Interfaces
{
    public interface IProductService
    {
        Task AddAsync(CreateProductDto productDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProductDto productDto);
        Task<ProductDto> GetByIdAsync(int id);
        Task<List<ProductDto>> GetAllAsync();
    }
}
