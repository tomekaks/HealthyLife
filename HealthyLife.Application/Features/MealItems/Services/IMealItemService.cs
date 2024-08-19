using HealthyLife.Application.Features.MealItems.Dtos;

namespace HealthyLife.Application.Features.MealItems.Services
{
    public interface IMealItemService
    {
        Task CreateAsync(CreateMealItemDto mealItemDto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateMealItemDto mealItemDto);
        Task<MealItemDto> GetByIdAsync(int id);
        Task<List<MealItemDto>> GetAllAsync(int mealId);
    }
}
