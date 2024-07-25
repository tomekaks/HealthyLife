using HealthyLife.Application.Features.Exercises.Dtos;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Exercises.Mappings
{
    public static class ExerciseMappings
    {
        public static ExerciseDto ToDto(this Exercise exercise)
        {
            return new ExerciseDto()
            {
                Id = exercise.Id,
                Name = exercise.Name,
                CaloriesPerHour = exercise.CaloriesPerHour
            };
        }
    }
}
