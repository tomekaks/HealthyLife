using HealthyLife.Application.Features.Meals.Dtos;
using HealthyLife.Application.Features.Meals.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using MyCalorieCounter.Application.DomainModels;
using System.Net.Http.Headers;

namespace HealthyLife.Application.Features.Meals.Services
{
    public class MealService : IMealService
    {
        private readonly IApplicationDbContext _context;

        public MealService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CreateMealDto mealDto)
        {
            var meal = new Meal()
            {
                ProductId = mealDto.ProductId,
                DailySumId = mealDto.DailySumId,
                Weight = mealDto.Weight,
                Calories = mealDto.Calories,
                Proteins = mealDto.Proteins,
                Carbs = mealDto.Carbs,
                Fats = mealDto.Fats,
                Fiber = mealDto.Fiber
            };

            await _context.Meals.AddAsync(meal);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var meal = await _context.Meals.FindAsync(id) ?? throw new Exception("Meal not found");
            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();
        }

        public async Task<List<MealDto>> GetAllAsync(int dailySumId)
        {
            var meals = await _context.Meals
                        .Include(meal => meal.Product)
                        .Where(meal => meal.DailySumId == dailySumId)
                        .ToListAsync();

            if (meals.Count < 1)
            {
                return new List<MealDto>();
            }

            var mealsDto = meals.Select(meal => meal.ToDto()).ToList();
            return mealsDto;
        }

        public async Task<MealDto> GetAsync(int id)
        {
            var meal = await _context.Meals.FindAsync(id) ?? throw new Exception("Meal not found");

            var mealDto = meal.ToDto();
            return mealDto;
        }

        public async Task UpdateAsync(UpdateMealDto mealDto)
        {
            var meal = await _context.Meals.FindAsync(mealDto.Id) ?? throw new Exception("Meal not found");

            meal.Weight = mealDto.Weight;
            meal.Calories = mealDto.Calories;
            meal.Proteins = mealDto.Proteins;
            meal.Carbs = mealDto.Carbs;
            meal.Fats = mealDto.Fats;
            meal.Fiber = mealDto.Fiber;

            _context.Meals.Update(meal);
            await _context.SaveChangesAsync();


        }
    }
}
