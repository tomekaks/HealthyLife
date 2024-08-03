using HealthyLife.Application.Features.Authentication.Services;
using HealthyLife.Application.Features.Products.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HealthyLife.Application
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
