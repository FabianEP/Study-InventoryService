using InventoryService.Application.Extensions;

namespace InventoryService.Api.Extensions
{
    public static class ApiServiceExtensions
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            // Add project dependency services

            services.AddApplicationServices();

            return services;
        }
    }
}
