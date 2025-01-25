using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Micronutrients.Dtos;
using HealthyLife.Application.Features.Micronutrients.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.Micronutrients.Services
{
    public class MicronutrientService : IMicronutrientService
    {
        private readonly IApplicationDbContext _context;

        public MicronutrientService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateMicronutrientDto micronutrientDto)
        {
            var micronutrient = new Micronutrient()
            {
                Name = micronutrientDto.Name,
                DailyRecommendedIntakeMg = micronutrientDto.DailyRecommendedIntakeMg,
                DailyIntakeLimitMg = micronutrientDto.DailyIntakeLimitMg
            };

            await _context.Micronutrients.AddAsync(micronutrient);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var micronutrient = await GetMicronutrientAsync(id);

            _context.Micronutrients.Remove(micronutrient);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MicronutrientDto>> GetAllAsync()
        {
            var micronutrients = await _context.Micronutrients.ToListAsync();

            if (micronutrients is null || micronutrients.Count < 1)
            {
                return new List<MicronutrientDto>();
            }

            var micronutrientDtos = micronutrients.Select(m => m.ToDto()).ToList();
            return micronutrientDtos;
        }

        public async Task<MicronutrientDto> GetByIdAsync(int id)
        {
            var micronutrient = await GetMicronutrientAsync(id);
            var micronutrientDto = micronutrient.ToDto();
            return micronutrientDto;
        }

        public async Task UpdateAsync(UpdateMicronutrientDto micronutrientDto)
        {
            var micronutrient = await GetMicronutrientAsync(micronutrientDto.Id);

            micronutrient.DailyRecommendedIntakeMg = micronutrientDto.DailyRecommendedIntakeMg;
            micronutrient.DailyIntakeLimitMg = micronutrientDto.DailyIntakeLimitMg;

            _context.Micronutrients.Update(micronutrient);
            await _context.SaveChangesAsync();
        }

        private async Task<Micronutrient> GetMicronutrientAsync(int id)
        {
            var micronutrient = await _context.Micronutrients.FindAsync(id)
                              ?? throw new Exception("Micronutrient not found");
            return micronutrient;
        }
    }

}
