namespace HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos
{
    public class CreateSupplementMicronutrientEntryDto
    {
        public int MicronutrientId { get; set; }
        public decimal Amount { get; set; }
        public int SupplementId { get; set; }
    }
}
