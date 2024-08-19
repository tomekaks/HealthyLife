namespace HealthyLife.Application.DomainModels
{
    public class DailySum
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double CaloriesBurned { get; set; }
        public List<Meal> Meals { get; set; }
        public List<Workout> Workouts { get; set; }

    }
}
