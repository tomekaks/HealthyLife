using HealthyLife.Application.Interfaces;
using HealthyLife.Persistence.Database;
using HealthyLife.Persistence.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyCalorieCounter.Application.DomainModels;

namespace HealthyLife.Persistence
{
    public static class PersistanceServicesConfiguration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentityCore<ApplicationUser>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.User.RequireUniqueEmail = true;
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();

            //services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            //{
            //    options.SignIn.RequireConfirmedAccount = false;
            //    options.User.RequireUniqueEmail = true;
            //})
            //.AddEntityFrameworkStores<ApplicationDbContext>();



            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();


            return services;
        }
    }
}
