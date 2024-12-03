using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Supplements.Dtos;
using HealthyLife.Application.Features.Supplements.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.Supplements.Services
{
    public class SupplementService : ISupplementService
    {
        private readonly IApplicationDbContext _context;

        public SupplementService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateSupplementDto supplementDto)
        {
            var supplement = new Supplement()
            {
                Name = supplementDto.Name,
                Category = supplementDto.Category,
                ServingForm = supplementDto.ServingForm,
                ServingUnit = supplementDto.ServingUnit,
                ServingSize = supplementDto.ServingSize,
                Servings = supplementDto.Servings,
                TotalQuantity = supplementDto.TotalQuantity,
                Price = supplementDto.Price,
                PricePerServing = supplementDto.PricePerServing,
                CreatedBy = supplementDto.CreatedBy
            };

            await _context.Supplements.AddAsync(supplement);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var supplement = await GetSupplementAsync(id);

            _context.Supplements.Remove(supplement);
            await _context.SaveChangesAsync();
        }

        public async Task<List<SupplementDto>> GetAllAsync()
        {
            var supplements = await _context.Supplements.ToListAsync();

            if(supplements is null ||  supplements.Count == 0)
            {
                return new List<SupplementDto>();
            }

            var supplementsDto = supplements.Select(sup => sup.ToDto()).ToList();
            return supplementsDto;
        }

        public async Task<List<SupplementDto>> GetByUserAsync(string userId)
        {
            var supplements = await _context.Supplements.Where(sup => sup.CreatedBy == userId).ToListAsync();

            if (supplements is null || supplements.Count == 0)
            {
                return new List<SupplementDto>();
            }

            var supplementsDto = supplements.Select(sup => sup.ToDto()).ToList();
            return supplementsDto;
        }

        public async Task<SupplementDto> GetByIdAsync(int id)
        {
            var supplement = await GetSupplementAsync(id);
            var supplementDto = supplement.ToDto();
            return supplementDto;
        }

        public async Task UpdateAsync(UpdateSupplementDto supplementDto)
        {
            var supplement = await GetSupplementAsync(supplementDto.Id);

            supplement.Category = supplementDto.Category;
            supplement.ServingForm = supplementDto.ServingForm;
            supplement.ServingUnit = supplementDto.ServingUnit;
            supplement.ServingSize = supplementDto.ServingSize;
            supplement.Servings = supplementDto.Servings;
            supplement.TotalQuantity = supplementDto.TotalQuantity;
            supplement.Price = supplementDto.Price;
            supplement.PricePerServing = supplementDto.PricePerServing;

            _context.Supplements.Update(supplement);
            await _context.SaveChangesAsync();
        }

        private async Task<Supplement> GetSupplementAsync(int id)
        {
            var supplement = await _context.Supplements.FindAsync(id) ?? throw new Exception("Supplement not found");
            return supplement;
        }
    }
}
