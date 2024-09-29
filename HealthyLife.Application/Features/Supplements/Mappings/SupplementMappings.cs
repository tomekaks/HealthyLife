using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Supplements.Dtos;

namespace HealthyLife.Application.Features.Supplements.Mappings
{
    public static class SupplementMappings
    {
        public static SupplementDto ToDto(this Supplement supplement)
        {
            return new SupplementDto()
            {
                Id = supplement.Id,
                Name = supplement.Name,
                Category = supplement.Category,
                ServingForm = supplement.ServingForm,
                ServingUnit = supplement.ServingUnit,
                ServingSize = supplement.ServingSize,
                Servings = supplement.Servings,
                TotalQuantity = supplement.TotalQuantity,
                Price = supplement.Price,
                PricePerServing = supplement.PricePerServing,
                CreatedBy = supplement.CreatedBy
            };
        }
    }
}
