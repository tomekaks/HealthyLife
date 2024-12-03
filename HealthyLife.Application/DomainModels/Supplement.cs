namespace HealthyLife.Application.DomainModels
{
    public class Supplement
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string ServingForm { get; set; } = string.Empty;
        public string ServingUnit { get; set; } = string.Empty;
        public int ServingSize { get; set; }
        public int Servings { get; set; }
        public int TotalQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal PricePerServing { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public List<MicronutrientEntry> Micronutrients { get; set; } = new();
    }
}
