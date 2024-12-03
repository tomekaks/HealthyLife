namespace HealthyLife.Application.DomainModels
{
    public class MicronutrientEntry()
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public Micronutrient Micronutrient { get; set; } = new();
        public int Amount { get; set; }
    }
}
