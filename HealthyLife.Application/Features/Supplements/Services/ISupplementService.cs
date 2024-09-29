
using HealthyLife.Application.Features.Supplements.Dtos;

namespace HealthyLife.Application.Features.Supplements.Services
{
    public interface ISupplementService
    {
        Task CreateAsync(CreateSupplementDto supplementDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateSupplementDto supplementDto);
        Task<SupplementDto> GetByIdAsync(int id);
        Task<List<SupplementDto>> GetAllAsync();
        Task<List<SupplementDto>> GetByUserAsync(string userId);
    }
}
