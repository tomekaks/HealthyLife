namespace MyCalorieCounter.Application.DomainModels
{
    public class Workout
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int DailySumId { get; set; }
        public int CaloriesBurned { get; set; }
        public int Minutes { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
