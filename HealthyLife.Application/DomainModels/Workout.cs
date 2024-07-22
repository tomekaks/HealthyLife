namespace MyCalorieCounter.Application.DomainModels
{
    public class Workout
    {
        public int Id { get; set; }
        public int DailySumId { get; set; }
        public DailySum DailySum { get; set; }
        public int CaloriesBurned { get; set; }
        public int Minutes { get; set; }
        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
