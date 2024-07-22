namespace MyCalorieCounter.Application.DomainModels
{
    public class Meal
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DailySumId { get; set; }
        public DailySum DailySum { get; set; }
        public int Weight { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
    }
}
