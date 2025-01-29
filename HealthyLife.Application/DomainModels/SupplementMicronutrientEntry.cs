namespace HealthyLife.Application.DomainModels
{
    public class SupplementMicronutrientEntry()
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public Micronutrient Micronutrient { get; set; } = new();
        public decimal Amount { get; set; }
        public int SupplementId { get; set; }
        public Supplement Supplement { get; set; } = new();
    }
}
