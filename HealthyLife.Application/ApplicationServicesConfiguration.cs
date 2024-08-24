using HealthyLife.Application.Features.Authentication.Services;
using HealthyLife.Application.Features.DailyGoals.Services;
using HealthyLife.Application.Features.DailySums.Services;
using HealthyLife.Application.Features.Exercises.Services;
using HealthyLife.Application.Features.MealItems.Services;
using HealthyLife.Application.Features.Meals.Services;
using HealthyLife.Application.Features.Products.Services;
using HealthyLife.Application.Features.Workouts.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyLife.Application
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IMealItemService, MealItemService>();
            services.AddScoped<IMealService, MealService>();
            services.AddScoped<IDailySumService, DailySumService>();
            services.AddScoped<IDailyGoalService, DailyGoalService>();
            services.AddScoped<IExerciseService, ExerciseService>();
            services.AddScoped<IWorkoutService, WorkoutService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
