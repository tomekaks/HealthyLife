namespace HealthyLife.Application.Features.DailySums.Dtos
{
    public class UpdateDailySumDto
    {
        public int Id { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double CaloriesBurned { get; set; }
    }
}
