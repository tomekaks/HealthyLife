namespace HealthyLife.Application.DomainModels
{
    public class MealItem
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
