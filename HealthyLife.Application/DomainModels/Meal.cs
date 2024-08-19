namespace HealthyLife.Application.DomainModels
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double Price { get; set; }
        public int DailySumId { get; set; }
        public DailySum DailySum { get; set; }
        public List<MealItem> MealItems { get; set; }
    }
}
