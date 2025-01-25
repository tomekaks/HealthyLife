using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Micronutrients.Dtos;

namespace HealthyLife.Application.Features.Micronutrients.Mappings
{
    public static class MicronutrientMappings
    {
        public static MicronutrientDto ToDto(this Micronutrient micronutrient)
        {
            return new MicronutrientDto()
            {
                Id = micronutrient.Id,
                Name = micronutrient.Name,
                DailyRecommendedIntakeMg = micronutrient.DailyRecommendedIntakeMg,
                DailyIntakeLimitMg = micronutrient.DailyIntakeLimitMg
            };
        }
    }
}
