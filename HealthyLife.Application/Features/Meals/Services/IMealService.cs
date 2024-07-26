using HealthyLife.Application.Features.Meals.Dtos;

namespace HealthyLife.Application.Features.Meals.Services
{
    public interface IMealService
    {
        Task AddAsync(CreateMealDto mealDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateMealDto mealDto);
        Task<MealDto> GetAsync(int id);
        Task<List<MealDto>> GetAllAsync(int dailySumId);
    }
}
