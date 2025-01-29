namespace HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos
{
    public class CreateProductMicronutrientEntryDto
    {
        public int MicronutrientId { get; set; }
        public decimal Amount { get; set; }
        public int ProductId { get; set; }
    }
}
