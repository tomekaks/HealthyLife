namespace HealthyLife.Application.Features.Meals.Dtos
{
    public class CreateMealDto
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public int DailySumId { get; set; }
        
    }
}
