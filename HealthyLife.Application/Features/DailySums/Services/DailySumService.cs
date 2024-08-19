using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.DailySums.Dtos;
using HealthyLife.Application.Features.DailySums.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HealthyLife.Application.Features.DailySums.Services
{
    public class DailySumService : IDailySumService
    {
        private readonly IApplicationDbContext _context;

        public DailySumService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(string userId)
        {
            var date = DateOnly.Parse(DateTime.Now.ToString());
            var dailySum = new DailySum { UserId = userId, Date = date };

            await _context.DailySums.AddAsync(dailySum);
            await _context.SaveChangesAsync();
        }

        public async Task<List<DailySumDto>> GetAllAsync(string userId)
        {
            var dailySums = await _context.DailySums
                            .Include(sum => sum.Workouts)
                            .Include(sum => sum.Meals)
                            .Where(sum => sum.UserId == userId)
                            .ToListAsync();

            if (dailySums.Count < 1)
            {
                return new List<DailySumDto>();
            }

            var dailySumsDto = dailySums.Select(sum => sum.ToDto()).ToList();
            return dailySumsDto;
        }

        public async Task<DailySumDto> GetByDateAsync(string userId, DateOnly date)
        {
            //var dailySum = await GetDailySumAsync(sum => sum.UserId == userId
            //                && sum.Date == date);

            var dailySum = await _context.DailySums
                            .Include(sum => sum.Workouts)
                            .Include(sum => sum.Meals)
                            .FirstOrDefaultAsync(sum => sum.UserId == userId && sum.Date == date);

            if (dailySum == null)
            {
                var entityEntry = await _context.DailySums.AddAsync(new DailySum { Date = date, UserId = userId });
                var newDailySum = entityEntry.Entity.ToDto();
                return newDailySum;
            }

            var dailySumDto = dailySum.ToDto();
            return dailySumDto;
        }

        public async Task<DailySumDto> GetByIdAsync(int id)
        {
            var dailySum = await GetDailySumAsync(sum => sum.Id == id);

            var dailySumDto = dailySum.ToDto();
            return dailySumDto;
        }

        public async Task UpdateAsync(UpdateDailySumDto dailySumDto)
        {
            var dailySum = await GetDailySumAsync(sum => sum.Id == dailySumDto.Id);

            dailySum.Calories = dailySumDto.Calories;
            dailySum.Proteins = dailySumDto.Proteins;
            dailySum.Carbs = dailySumDto.Carbs;
            dailySum.Fats = dailySumDto.Fats;
            dailySum.Fiber = dailySumDto.Fiber;
            dailySum.CaloriesBurned = dailySumDto.CaloriesBurned;

            _context.DailySums.Update(dailySum);
            await _context.SaveChangesAsync();
        }

        private async Task<DailySum> GetDailySumAsync(Expression<Func<DailySum, bool>> expression)
        {
            var dailySum = await _context.DailySums
                            .Include(sum => sum.Workouts)
                            .Include(sum => sum.Meals)
                            .FirstOrDefaultAsync(expression)
                            ?? throw new Exception("DailySum does not exist");

            return dailySum;
        }
    }
}
