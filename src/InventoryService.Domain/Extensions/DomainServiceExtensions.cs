using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryService.Domain.Services;
using InventoryService.Domain.Services.Abstractions;
using InventoryService.Infrastructure.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace InventoryService.Domain.Extensions
{
    public static class DomainServiceExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IDomainService, DomainService>();

            services.AddInfrastructureServices();


            // TODO: Add database here, Can be an extension method
            //services.AddSqlDatabase<InventoryDbContext>();

            //services.AddScoped<IDbContext, InventoryDbContext>();

            return services;
        }
    }
}
