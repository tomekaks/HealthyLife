using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.MealItems.Dtos;
using HealthyLife.Application.Features.MealItems.Mappings;
using HealthyLife.Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HealthyLife.Application.Features.MealItems.Services
{
    public class MealItemService : IMealItemService
    {
        private readonly IApplicationDbContext _context;

        public MealItemService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateMealItemDto mealItemDto)
        {
            var mealItem = new MealItem()
            {
                Calories = mealItemDto.Calories,
                Proteins = mealItemDto.Proteins,
                Carbs = mealItemDto.Carbs,
                Fats = mealItemDto.Fats,
                Fiber = mealItemDto.Fiber,
                Price = mealItemDto.Price,
                ProductId = mealItemDto.ProductId,
                MealId = mealItemDto.MealId
            };

            await _context.MealItems.AddAsync(mealItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var mealItem = await GetMealItemAsync(id);
            _context.MealItems.Remove(mealItem);
            await _context.SaveChangesAsync();

        }

        public async Task<List<MealItemDto>> GetAllAsync(int mealItemId)
        {
            var mealItems = await _context.MealItems
                            .Include(item => item.Product)
                            .Where(item => item.MealId == mealItemId)
                            .ToListAsync();

            if (mealItems.Count < 1)
            {
                return new List<MealItemDto>();
            }

            var mealItemsDto = mealItems.Select(meal => meal.ToDto()).ToList();
            return mealItemsDto;
        }

        public async Task<MealItemDto> GetByIdAsync(int id)
        {
            var mealItem = await GetMealItemAsync(id);
            var mealItemDto = mealItem.ToDto();
            return mealItemDto;
        }

        public async Task UpdateAsync(UpdateMealItemDto mealItemDto)
        {
            var mealItem = await GetMealItemAsync(mealItemDto.Id);

            mealItem.Weight = mealItemDto.Weight;
            mealItem.Calories = mealItemDto.Calories;
            mealItem.Proteins = mealItemDto.Proteins;
            mealItem.Carbs = mealItemDto.Carbs;
            mealItem.Fiber = mealItemDto.Fiber;
            mealItem.Price = mealItem.Price;

            _context.MealItems.Update(mealItem);
            await _context.SaveChangesAsync();
        }

        private async Task<MealItem> GetMealItemAsync(int id)
        {
            var mealItem = await _context.MealItems.FindAsync(id) ?? throw new Exception("MealItem not found");
            return mealItem;
        }
    }
}
