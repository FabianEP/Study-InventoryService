using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryService.Application.Application;
using InventoryService.Domain.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryService.Application.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
        {
            // Add Domain layer services
            services.AddDomainServices();

            // Add Application services
            services.AddScoped<AppService>();

            return services;
        }
    }
}
