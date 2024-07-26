using HealthyLife.Application.Features.DailySums.Dtos;
using HealthyLife.Application.Features.Meals.Mappings;
using HealthyLife.Application.Features.Workouts.Mappings;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.DailySums.Mappings
{
    public static class DailySumMappings
    {
        public static DailySumDto ToDto(this DailySum dailySum)
        {
            return new DailySumDto()
            {
                Id = dailySum.Id,
                Date = dailySum.Date,
                UserId = dailySum.UserId,
                Calories = dailySum.Calories,
                Proteins = dailySum.Proteins,
                Carbs = dailySum.Carbs,
                Fats = dailySum.Fats,
                Fiber = dailySum.Fiber,
                CaloriesBurned = dailySum.CaloriesBurned,
                Meals = dailySum.Meals.Select(meal => meal.ToDto()).ToList(),
                Workouts = dailySum.Workouts.Select(workout => workout.ToDto()).ToList()
            };
        }
    }
}
