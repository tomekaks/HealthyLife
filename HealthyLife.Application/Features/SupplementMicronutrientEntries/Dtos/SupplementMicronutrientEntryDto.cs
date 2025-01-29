using HealthyLife.Application.Features.Micronutrients.Dtos;
using HealthyLife.Application.Features.Supplements.Dtos;

namespace HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos
{
    public class SupplementMicronutrientEntryDto
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public MicronutrientDto MicronutrientDto { get; set; } = new();
        public decimal Amount { get; set; }
        public int SupplementId { get; set; }
        public SupplementDto SupplementDto { get; set; } = new();
    }
}
