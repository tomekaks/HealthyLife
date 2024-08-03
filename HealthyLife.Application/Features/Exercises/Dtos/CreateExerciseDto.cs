namespace HealthyLife.Application.Features.Exercises.Dtos
{
    public class CreateExerciseDto
    {
        public string Name { get; set; }
        public int CaloriesPerHour { get; set; }
        public string CreatedBy { get; set; }      
    }
}
