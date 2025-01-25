﻿namespace HealthyLife.Application.Features.Micronutrients.Dtos
{
    public class CreateMicronutrientDto
    {
        public string Name { get; set; } = string.Empty;
        public decimal DailyRecommendedIntakeMg { get; set; }
        public decimal? DailyIntakeLimitMg { get; set; }
    }
}
