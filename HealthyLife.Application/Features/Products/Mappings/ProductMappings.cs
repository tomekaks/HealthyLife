using HealthyLife.Application.Features.Products.Dtos;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Products.Mappings
{
    public static class ProductMappings
    {
        public static ProductDto ToDto(this Product product)
        {
            return new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Calories = product.Calories,
                Proteins = product.Proteins,
                Carbs = product.Carbs,
                Fats = product.Fats,
                Fiber = product.Fiber,
                Price = product.Price,
                CreatedBy = product.CreatedBy
            };
        }
    }
}
