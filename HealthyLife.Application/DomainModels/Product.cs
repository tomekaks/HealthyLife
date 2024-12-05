namespace HealthyLife.Application.DomainModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double Price { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public List<ProductMicronutrientEntry> Micronutrients { get; set; } = new();

    }
}
