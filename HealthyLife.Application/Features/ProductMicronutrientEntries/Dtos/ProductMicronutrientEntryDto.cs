using HealthyLife.Application.Features.Micronutrients.Dtos;
using HealthyLife.Application.Features.Products.Dtos;

namespace HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos
{
    public class ProductMicronutrientEntryDto
    {
        public int Id { get; set; }
        public int MicronutrientId { get; set; }
        public MicronutrientDto MicronutrientDto { get; set; } = new();
        public decimal Amount { get; set; }
        public int ProductId { get; set; }
        public ProductDto ProductDto { get; set; } = new();
    }
}
