namespace HealthyLife.Application.Features.Micronutrients.Dtos
{
    public class UpdateMicronutrientDto
    {
        public int Id { get; set; }
        public decimal DailyRecommendedIntakeMg { get; set; }
        public decimal? DailyIntakeLimitMg { get; set; }
    }
}
