using HealthyLife.Application.Features.Products.Interfaces;
using HealthyLife.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence.Repositories
{
    internal class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<Product> _products;

        public ProductRepository(ApplicationDbContext context): base(context)
        {
            _context = context;
            _products = _context.Products;
        }
    }
}
