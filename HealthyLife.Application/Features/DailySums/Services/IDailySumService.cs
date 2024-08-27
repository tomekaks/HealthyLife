using HealthyLife.Application.Features.DailySums.Dtos;

namespace HealthyLife.Application.Features.DailySums.Services
{
    public interface IDailySumService
    {
        Task CreateAsync(string userId, string date);
        Task UpdateAsync(UpdateDailySumDto dailySumDto);
        Task<DailySumDto> GetByIdAsync(int id);
        Task<DailySumDto> GetByDateAsync(string userId, DateOnly date);
        Task<List<DailySumDto>> GetAllAsync(string userId);
    }
}
