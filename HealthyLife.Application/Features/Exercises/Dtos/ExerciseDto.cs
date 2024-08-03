namespace HealthyLife.Application.Features.Exercises.Dtos
{
    public class ExerciseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CaloriesPerHour { get; set; }
        public string CreatedBy { get; set; }
    }
}
