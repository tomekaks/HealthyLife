﻿namespace HealthyLife.Application.Features.Meals.Dtos
{
    public class CreateMealDto
    {
        public int ProductId { get; set; }
        public int DailySumId { get; set; }
        public int Weight { get; set; }
        public double Calories { get; set; }
        public double Proteins { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
    }
}
