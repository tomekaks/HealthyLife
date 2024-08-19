using HealthyLife.Application.Features.MealItems.Dtos;

namespace HealthyLife.Application.Features.Meals.Dtos
{
    public class MealDto
    {
        public int Id { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double Price { get; set; }
        public int DailySumId { get; set; }
        public List<MealItemDto> MealItemsDto { get; set; }
    }
}
