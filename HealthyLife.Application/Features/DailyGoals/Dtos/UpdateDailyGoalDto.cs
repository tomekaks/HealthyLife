namespace HealthyLife.Application.Features.DailyGoals.Dtos
{
    public class UpdateDailyGoalDto
    {
        public int Id { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
    }
}
