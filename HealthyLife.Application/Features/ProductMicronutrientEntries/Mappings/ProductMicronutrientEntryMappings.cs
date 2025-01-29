using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Micronutrients.Mappings;
using HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.Products.Mappings;

namespace HealthyLife.Application.Features.ProductMicronutrientEntries.Mappings
{
    public static class ProductMicronutrientEntryMappings
    {
        public static ProductMicronutrientEntryDto ToDto(this ProductMicronutrientEntry productMicronutrientEntry)
        {
            return new ProductMicronutrientEntryDto()
            {
                Id = productMicronutrientEntry.Id,
                Amount = productMicronutrientEntry.Amount,
                MicronutrientId = productMicronutrientEntry.MicronutrientId,
                MicronutrientDto = productMicronutrientEntry.Micronutrient.ToDto(),
                ProductId = productMicronutrientEntry.ProductId,
                ProductDto = productMicronutrientEntry.Product.ToDto()
            };
        }
    }
}
