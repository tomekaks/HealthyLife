using HealthyLife.Application.Features.Meals.Dtos;

namespace HealthyLife.Application.Features.Meals.Services
{
    public interface IMealService
    {
        Task CreateAsync(CreateMealDto mealDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateMealDto mealDto);
        Task<MealDto> GetByIdAsync(int id);
        Task<List<MealDto>> GetAllAsync(int dailySumId);
    }
}
