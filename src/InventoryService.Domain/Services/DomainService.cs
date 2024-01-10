using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryService.Domain.Services.Abstractions;
using InventoryService.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryService.Domain.Services
{
    public class DomainService : IDomainService
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IDomainService, DomainService>();

            // Add Infrastructure Layer
            services.AddInfrastructureServices();

            // TODO: Add Database here
            //services.AddSqlDatabase<InventoryDbContext>();

            //services.AddScoped<IDbContext, InventoryDbContext>();



            return services;
        }
    }
}
