using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.MealItems.Dtos;
using HealthyLife.Application.Features.Products.Mappings;

namespace HealthyLife.Application.Features.MealItems.Mappings
{
    public static class MealItemMappings
    {
        public static MealItemDto ToDto(this MealItem mealItem)
        {
            return new MealItemDto()
            {
                Id = mealItem.Id,
                Weight = mealItem.Weight,
                Calories = mealItem.Calories,
                Proteins = mealItem.Proteins,
                Carbs = mealItem.Carbs,
                Fats = mealItem.Fats,
                Fiber = mealItem.Fiber,
                Price = mealItem.Price,
                ProductId = mealItem.ProductId,
                Product = mealItem.Product.ToDto(),
                MealId = mealItem.MealId
            };
        }
    }
}
