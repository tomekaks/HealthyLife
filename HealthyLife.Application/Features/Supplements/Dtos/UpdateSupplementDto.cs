﻿namespace HealthyLife.Application.Features.Supplements.Dtos
{
    public class UpdateSupplementDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string ServingForm { get; set; }
        public string ServingUnit { get; set; }
        public int ServingSize { get; set; }
        public int Servings { get; set; }
        public int TotalQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal PricePerServing { get; set; }

    }
}
