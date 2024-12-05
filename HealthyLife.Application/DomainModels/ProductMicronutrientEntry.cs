namespace HealthyLife.Application.DomainModels
{
    public class ProductMicronutrientEntry()
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public Micronutrient Micronutrient { get; set; } = new();
        public decimal Amount { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
