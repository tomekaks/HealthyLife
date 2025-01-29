using HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos;

namespace HealthyLife.Application.Features.ProductMicronutrientEntries.Services
{
    public interface IProductMicronutrientEntryService
    {
        Task CreateAsync(CreateProductMicronutrientEntryDto productMicronutrientEntryDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProductMicronutrientEntryDto productMicronutrientEntryDto);
        Task<ProductMicronutrientEntryDto> GetById(int id);
    }
}
