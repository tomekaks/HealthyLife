using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.SupplementMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.SupplementMicronutrientEntries.Mappings;
using HealthyLife.Application.Interfaces;

namespace HealthyLife.Application.Features.SupplementMicronutrientEntries.Services
{
    public class SupplementMicronutrientEntryService : ISupplementMicronutrientEntryService
    {
        private readonly IApplicationDbContext _context;

        public SupplementMicronutrientEntryService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto)
        {
            var supplementMicronutrientEntry = new SupplementMicronutrientEntry()
            {
                Amount = supplementMicronutrientEntryDto.Amount,
                MicronutrientId = supplementMicronutrientEntryDto.MicronutrientId,
                SupplementId = supplementMicronutrientEntryDto.SupplementId,
            };

            await _context.SupplementMicronutrientEntries.AddAsync(supplementMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var supplemenetMicronutrientEntry = await GetSupplementMicronutrientEntryAsync(id);

            _context.SupplementMicronutrientEntries.Remove(supplemenetMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        public async Task<SupplementMicronutrientEntryDto> GetByIdAsync(int id)
        {
            var supplementMicronutrientEntry = await GetSupplementMicronutrientEntryAsync(id);
            var supplementMicronutrientEntryDto = supplementMicronutrientEntry.ToDto();
            return supplementMicronutrientEntryDto;
        }

        public async Task UpdateAsync(UpdateSupplementMicronutrientEntryDto supplementMicronutrientEntryDto)
        {
            var supplementMicronutrientEntry = await GetSupplementMicronutrientEntryAsync(supplementMicronutrientEntryDto.Id);

            supplementMicronutrientEntry.Amount = supplementMicronutrientEntryDto.Amount;

            _context.SupplementMicronutrientEntries.Update(supplementMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        private async Task<SupplementMicronutrientEntry> GetSupplementMicronutrientEntryAsync(int id)
        {
            var supplementMicronutrientEntry = await _context.SupplementMicronutrientEntries.FindAsync(id)
                              ?? throw new Exception("Entry not found");
            return supplementMicronutrientEntry;
        }
    }
}
