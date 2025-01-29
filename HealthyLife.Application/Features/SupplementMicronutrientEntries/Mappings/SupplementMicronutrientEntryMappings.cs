using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Micronutrients.Mappings;
using HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.Supplements.Mappings;

namespace HealthyLife.Application.Features.SupplementMicronutrientEntries.Mappings
{
    public static class SupplementMicronutrientEntryMappings
    {
        public static SupplementMicronutrientEntryDto ToDto(this SupplementMicronutrientEntry supplementMicronutrientEntry)
        {
            return new SupplementMicronutrientEntryDto()
            {
                Id = supplementMicronutrientEntry.Id,
                Amount = supplementMicronutrientEntry.Amount,
                MicronutrientId = supplementMicronutrientEntry.MicronutrientId,
                MicronutrientDto = supplementMicronutrientEntry.Micronutrient.ToDto(),
                SupplementId = supplementMicronutrientEntry.SupplementId,
                SupplementDto = supplementMicronutrientEntry.Supplement.ToDto()
            };
        }
    }
}
