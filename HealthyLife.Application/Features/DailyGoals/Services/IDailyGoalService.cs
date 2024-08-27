using HealthyLife.Application.Features.DailyGoals.Dtos;

namespace HealthyLife.Application.Features.DailyGoals.Services
{
    public interface IDailyGoalService
    {
        Task UpdateAsync(UpdateDailyGoalDto dailyGoalDto);
        Task<DailyGoalDto> GetAsync(string userId);
    }
}
