using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.Meals.Dtos;
using HealthyLife.Application.Features.Meals.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.Meals.Services
{
    public class MealService : IMealService
    {
        private readonly IApplicationDbContext _context;

        public MealService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateMealDto mealDto)
        {
            var meal = new Meal()
            {
                DailySumId = mealDto.DailySumId,
                Calories = mealDto.Calories,
                Proteins = mealDto.Proteins,
                Carbs = mealDto.Carbs,
                Fats = mealDto.Fats,
                Fiber = mealDto.Fiber,
                Price = mealDto.Price
            };

            await _context.Meals.AddAsync(meal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var meal = await GetMealAsync(id);
            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MealDto>> GetAllAsync(int dailySumId)
        {
            var meals = await _context.Meals
                        .Include(meal => meal.MealItems)
                        .ThenInclude(item => item.Product)
                        .ToListAsync();

            if (meals.Count < 1)
            {
                return new List<MealDto>();
            }

            var mealsDto = meals.Select(meal => meal.ToDto()).ToList();
            return mealsDto;
        }

        public async Task<MealDto> GetByIdAsync(int id)
        {
            var meal = await GetMealAsync(id);

            var mealDto = meal.ToDto();
            return mealDto;
        }

        public async Task UpdateAsync(UpdateMealDto mealDto)
        {
            var meal = await GetMealAsync(mealDto.Id);

            meal.Name = mealDto.Name;
            meal.Calories = mealDto.Calories;
            meal.Proteins = mealDto.Proteins;
            meal.Carbs = mealDto.Carbs;
            meal.Fats = mealDto.Fats;
            meal.Fiber = mealDto.Fiber;
            meal.Price = mealDto.Price;

            _context.Meals.Update(meal);
            await _context.SaveChangesAsync();
        }

        private async Task<Meal> GetMealAsync(int id)
        {
            var meal = await _context.Meals.FindAsync(id) ?? throw new Exception("Meal not found");
            return meal;
        }
    }
}
