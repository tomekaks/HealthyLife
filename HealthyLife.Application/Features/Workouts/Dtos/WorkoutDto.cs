using HealthyLife.Application.Features.Exercises.Dtos;

namespace HealthyLife.Application.Features.Workouts.Dtos
{
    public class WorkoutDto
    {
        public int Id { get; set; }
        public int DailySumId { get; set; }
        public int CaloriesBurned { get; set; }
        public int Minutes { get; set; }
        public ExerciseDto Exercise { get; set; }
    }
}
