namespace HealthyLife.Application.DomainModels
{
    public class SupplementMicronutrientEntry()
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public Micronutrient Micronutrient { get; set; } = new();
        public int Amount { get; set; }
        public int SuppelementId { get; set; }
        public Supplement Supplement { get; set; } = new();
    }
}
