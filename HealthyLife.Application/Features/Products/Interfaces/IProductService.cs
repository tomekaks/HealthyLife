using HealthyLife.Application.Features.Products.Dtos;

namespace HealthyLife.Application.Features.Products.Interfaces
{
    public interface IProductService
    {
        Task AddAsync(CreateProductDto productDto);
        Task Delete(int id);
        Task Update(UpdateProductDto productDto);
        Task<ProductDto> GetById(int id);
        Task<List<ProductDto>> GetAll();
    }
}
