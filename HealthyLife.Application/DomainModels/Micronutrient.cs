namespace HealthyLife.Application.DomainModels
{
    public class Micronutrient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal DailyRecommendedIntakeMg { get; set; }
        public decimal? DailyIntakeLimitMg { get; set; }
    }
}
