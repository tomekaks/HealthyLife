using HealthyLife.Application.Features.Meals.Dtos;
using HealthyLife.Application.Features.Products.Mappings;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Meals.Mappings
{
    public static class MealMappings
    {
        public static MealDto ToDto(this Meal meal)
        {
            return new MealDto()
            {
                Id = meal.Id,
                ProductDto = meal.Product.ToDto(),
                DailySumId = meal.DailySumId,
                Weight = meal.Weight,
                Calories = meal.Calories,
                Proteins = meal.Proteins,
                Carbs = meal.Carbs,
                Fats = meal.Fats,
                Fiber = meal.Fiber

            };
        }
    }
}
