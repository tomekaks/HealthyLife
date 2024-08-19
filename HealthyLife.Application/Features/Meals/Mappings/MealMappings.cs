using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.MealItems.Mappings;
using HealthyLife.Application.Features.Meals.Dtos;

namespace HealthyLife.Application.Features.Meals.Mappings
{
    public static class MealMappings
    {
        public static MealDto ToDto(this Meal meal)
        {
            return new MealDto()
            {
                Id = meal.Id,
                Calories = meal.Calories,
                Proteins = meal.Proteins,
                Carbs = meal.Carbs,
                Fats = meal.Fats,
                Fiber = meal.Fiber,
                Price = meal.Price,
                DailySumId = meal.DailySumId,
                MealItemsDto = meal.MealItems.Select(meal => meal.ToDto()).ToList()
            };
        }
    }
}
