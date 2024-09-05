using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.DailySums.Dtos;
using HealthyLife.Application.Features.DailySums.Mappings;
using HealthyLife.Application.Features.Meals.Mappings;
using HealthyLife.Application.Features.Meals.Dtos;
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
            var dailySum = await GetDailySumAsync(sum => sum.UserId == userId && sum.Date == date);

            if (dailySum == null)
            {
                await CreateAsync(userId, date);
                dailySum = await GetDailySumAsync(sum => sum.UserId == userId && sum.Date == date)
                    ?? throw new Exception("Could not find newly created Daily sum.");
            }

            var dailySumDto = dailySum.ToDto();
            var sumAfterPropertyCalculation = CalculateProperties(dailySumDto);

            return sumAfterPropertyCalculation;
        }

        public async Task<DailySumDto> GetByIdAsync(int id)
        {
            var dailySum = await GetDailySumAsync(sum => sum.Id == id) ?? throw new Exception("Daily sum does not exist.");

            var dailySumDto = dailySum.ToDto();
            return dailySumDto;
        }

        public async Task UpdateAsync(UpdateDailySumDto dailySumDto)
        {
            var dailySum = await GetDailySumAsync(sum => sum.Id == dailySumDto.Id) ?? throw new Exception("Daily sum does not exist.");

            dailySum.Calories = dailySumDto.Calories;
            dailySum.Proteins = dailySumDto.Proteins;
            dailySum.Carbs = dailySumDto.Carbs;
            dailySum.Fats = dailySumDto.Fats;
            dailySum.Fiber = dailySumDto.Fiber;
            dailySum.CaloriesBurned = dailySumDto.CaloriesBurned;

            _context.DailySums.Update(dailySum);
            await _context.SaveChangesAsync();
        }

        private async Task CreateAsync(string userId, DateOnly date)
        {
            var dailySum = new DailySum { UserId = userId, Date = date };

            await _context.DailySums.AddAsync(dailySum);
            await _context.SaveChangesAsync();

            var createdDailySum = await _context.DailySums.FirstOrDefaultAsync(item => item.UserId == userId && item.Date == date)
                                  ?? throw new Exception("Could not find newly created Daily sum.");

            await CreateInitialMealsAsync(createdDailySum);
        }

        private async Task<DailySum?> GetDailySumAsync(Expression<Func<DailySum, bool>> expression)
        {
            var dailySum = await _context.DailySums
                            .Include(sum => sum.Workouts)
                            .ThenInclude(workout => workout.Exercise)
                            .Include(sum => sum.Meals)
                            .ThenInclude(meal => meal.MealItems)
                            .ThenInclude(item => item.Product)
                            .FirstOrDefaultAsync(expression);

            return dailySum;
        }

        private async Task CreateInitialMealsAsync(DailySum sum)
        {
            var nameList = new List<string> { "First meal", "Second meal", "Third meal", "Fourth meal" };
            for(var i = 1; i <= 4; i++)
            {
                var meal = new Meal()
                {
                    Position = i,
                    DailySumId = sum.Id,
                    Name = nameList[i - 1]
                };
                await _context.Meals.AddAsync(meal);
            }
            await _context.SaveChangesAsync();
        }

        private DailySumDto CalculateProperties(DailySumDto sum)
        {
            foreach(var meal in sum.Meals)
            {
                meal.Calories = meal.MealItems.Sum(item =>  item.Calories);
                meal.Proteins = meal.MealItems.Sum(item =>  item.Proteins);
                meal.Carbs = meal.MealItems.Sum(item =>  item.Carbs);
                meal.Fats = meal.MealItems.Sum(item =>  item.Fats);
                meal.Fiber = meal.MealItems.Sum(item =>  item.Fiber);
                meal.Price = meal.MealItems.Sum(item =>  item.Price);

                sum.Calories += meal.Calories;
                sum.Proteins += meal.Proteins;
                sum.Carbs += meal.Carbs;
                sum.Fats += meal.Fats;
                sum.Fiber += meal.Fiber;
                sum.Price += meal.Price;
            }

            foreach (var workout in sum.Workouts)
            {
                sum.CaloriesBurned += workout.CaloriesBurned;
            }

            return sum;
        }
    }
}
