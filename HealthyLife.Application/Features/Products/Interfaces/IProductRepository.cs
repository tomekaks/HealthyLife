﻿using HealthyLife.Application.Interfaces;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Application.Features.Products.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<Product> GetByIdAsync(int id);
        Task<List<Product>> GetAllAsync();
    }
}
