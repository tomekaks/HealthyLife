namespace HealthyLife.Application.DomainModels
{
    public class Micronutrient
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IntakeUnit { get; set; } = string.Empty;
        public int DailyRecommendedIntake { get; set; }
    }
}
