using HealthyLife.Application.Features.Products.Dtos;
using HealthyLife.Application.Features.Products.Interfaces;
using HealthyLife.Application.Features.Products.Mappings;
using HealthyLife.Application.Interfaces;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Products.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(CreateProductDto productDto)
        {
            var product = new Product()
            {
                Name = productDto.Name,
                Calories = productDto.Calories,
                Proteins = productDto.Proteins,
                Carbs = productDto.Carbs,
                Fats = productDto.Fats,
                Fiber = productDto.Fiber
            };

            await _productRepository.AddAsync(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            _productRepository.Delete(product);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var products = await _productRepository.GetAllAsync();

            if (products is null || products.Count < 1)
            {
                return new List<ProductDto>();
            }

            var productsDtos = products.Select(product => product.ToDto()).ToList();
            return productsDtos;
        }

        public async Task<ProductDto> GetById(int id)
        {
            var product = await _productRepository.GetByIdAsync(id);
            var productDto = product.ToDto() ?? throw new Exception("Product now found");
            return productDto;
        }

        public async Task Update(UpdateProductDto productDto)
        {
            var product = await _productRepository.GetByIdAsync(productDto.Id) ?? throw new Exception("Product not found");

            product.Calories = productDto.Calories;
            product.Proteins = productDto.Proteins;
            product.Carbs = productDto.Carbs;
            product.Fats = productDto.Fats;
            product.Fiber = productDto.Fiber;

            _productRepository.Update(product);
            await _unitOfWork.SaveAsync();
        }
    }
}
