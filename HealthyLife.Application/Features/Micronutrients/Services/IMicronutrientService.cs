using HealthyLife.Application.Features.Micronutrients.Dtos;

namespace HealthyLife.Application.Features.Micronutrients.Services
{
    public interface IMicronutrientService
    {
        Task CreateAsync(CreateMicronutrientDto micronutrientDto);
        Task DeleteAsync(int id);
        Task<List<MicronutrientDto>> GetAllAsync();
        Task<MicronutrientDto> GetByIdAsync(int id);
        Task UpdateAsync(UpdateMicronutrientDto micronutrientDto);
    }

}
