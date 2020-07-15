using CG.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CG.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterInfrastructureDependencies(this IServiceCollection services)
        {
            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("CONNECTION_STRING")))
            {
                services.AddDbContext<DataContext>(options => options.UseSqlServer(Environment.GetEnvironmentVariable("CONNECTION_STRING")));
            }
            else
            {
                services.AddDbContext<DataContext>();
            }
            
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            return services;
        }
    }
}
