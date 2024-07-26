using HealthyLife.Application.Features.DailyGoals.Dtos;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.DailyGoals.Mappings
{
    public static class DailyGoalMappings
    {
        public static DailyGoalDto ToDto(this DailyGoal dailyGoal)
        {
            return new DailyGoalDto()
            {
                Id = dailyGoal.Id,
                UserId = dailyGoal.UserId,
                Calories = dailyGoal.Calories,
                Proteins = dailyGoal.Proteins,
                Carbs = dailyGoal.Carbs,
                Fats = dailyGoal.Fats,
                Fiber = dailyGoal.Fiber
            };
        }
    }
}
