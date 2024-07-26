namespace HealthyLife.Application.Features.Workouts.Dtos
{
    public class CreateWorkoutDto
    {
        public int DailySumId { get; set; }
        public int CaloriesBurned { get; set; }
        public int Minutes { get; set; }
        public int ExerciseId { get; set; }
    }
}
