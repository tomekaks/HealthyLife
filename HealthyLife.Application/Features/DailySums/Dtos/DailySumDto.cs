using HealthyLife.Application.Features.Meals.Dtos;
using HealthyLife.Application.Features.Workouts.Dtos;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.DailySums.Dtos
{
    public class DailySumDto
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string UserId { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double CaloriesBurned { get; set; }
        public List<MealDto> Meals { get; set; }
        public List<WorkoutDto> Workouts { get; set; }
    }
}
