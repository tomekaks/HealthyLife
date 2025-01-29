using HealthyLife.Application.DomainModels;
using HealthyLife.Application.Features.ProductMicronutrientEntries.Dtos;
using HealthyLife.Application.Features.ProductMicronutrientEntries.Mappings;
using HealthyLife.Application.Interfaces;

namespace HealthyLife.Application.Features.ProductMicronutrientEntries.Services
{
    public class ProductMicronutrientEntryService : IProductMicronutrientEntryService
    {
        private readonly IApplicationDbContext _context;

        public ProductMicronutrientEntryService(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(CreateProductMicronutrientEntryDto productMicronutrientEntryDto)
        {
            var productMicronutrientEntry = new ProductMicronutrientEntry()
            {
                Amount = productMicronutrientEntryDto.Amount,
                MicronutrientId = productMicronutrientEntryDto.MicronutrientId,
                ProductId = productMicronutrientEntryDto.ProductId,
            };

            await _context.ProductMicronutrientEntries.AddAsync(productMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var productMicronutrientEntry = await GetProductMicronutrientEntryAsync(id);

            _context.ProductMicronutrientEntries.Remove(productMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(UpdateProductMicronutrientEntryDto productMicronutrientEntryDto)
        {
            var productMicronutrientEntry = await GetProductMicronutrientEntryAsync(productMicronutrientEntryDto.Id);

            productMicronutrientEntry.Amount = productMicronutrientEntryDto.Amount;

            _context.ProductMicronutrientEntries.Update(productMicronutrientEntry);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductMicronutrientEntryDto> GetById(int id)
        {
            var productMicronutrientEntry = await GetProductMicronutrientEntryAsync(id);
            var productMicronutrientEntryDto = productMicronutrientEntry.ToDto();
            return productMicronutrientEntryDto;
        }

        private async Task<ProductMicronutrientEntry> GetProductMicronutrientEntryAsync(int id)
        {
            var productMicronutrientEntry = await _context.ProductMicronutrientEntries.FindAsync(id)
                              ?? throw new Exception("Entry not found");
            return productMicronutrientEntry;
        }
    }
}
