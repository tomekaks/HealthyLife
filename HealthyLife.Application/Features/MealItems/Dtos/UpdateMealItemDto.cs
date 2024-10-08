﻿namespace HealthyLife.Application.Features.MealItems.Dtos
{
    public class UpdateMealItemDto
    {
        public int Id { get; set; }
        public int Weight { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public double Fiber { get; set; }
        public double Price { get; set; }
    }
}
