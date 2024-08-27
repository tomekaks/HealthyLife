using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.DailyGoals.Dtos;
using HealthyLife.Application.Features.DailyGoals.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.DailyGoals.Services
{
    public class DailyGoalService : IDailyGoalService
    {
        private readonly IApplicationDbContext _context;

        public DailyGoalService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DailyGoalDto> GetAsync(string userId)
        {
            var dailyGoal = await _context.DailyGoals.FirstOrDefaultAsync(d => d.UserId == userId);
            
            if(dailyGoal == null)
            {
                await CreateAsync(userId);
                dailyGoal = await _context.DailyGoals.FirstOrDefaultAsync(d => d.UserId == userId);
            }

            var dailyGoalDto = dailyGoal.ToDto();
            return dailyGoalDto;
        }

        public async Task UpdateAsync(UpdateDailyGoalDto dailyGoalDto)
        {
            var dailyGoal = await _context.DailyGoals.FindAsync(dailyGoalDto.Id)
                            ?? throw new Exception("DailyGoal not found");

            dailyGoal.Calories = dailyGoalDto.Calories;
            dailyGoal.Proteins = dailyGoalDto.Proteins;
            dailyGoal.Carbs = dailyGoalDto.Carbs;
            dailyGoal.Fats = dailyGoalDto.Fats;
            dailyGoal.Fiber = dailyGoalDto.Fiber;

            _context.DailyGoals.Update(dailyGoal);
            await _context.SaveChangesAsync();
        }

        private async Task CreateAsync(string userId)
        {
            var dailyGoal = new DailyGoal()
            {
                UserId = userId
            };

            await _context.DailyGoals.AddAsync(dailyGoal);
            await _context.SaveChangesAsync();
        }
    }
}
