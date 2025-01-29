using HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos;

namespace HealthyLife.Application.Features.SupplementMicronutrientEntries.Services
{
    public interface ISupplementMicronutrientEntryService
    {
        Task CreateAsync(CreateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto);
        Task<SupplementMicronutrientEntryDto> GetByIdAsync(int id);
    }
}
