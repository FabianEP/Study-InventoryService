namespace InventoryService.Api.Extensions
{
    public static class ServiceInitializerExtensions
    {
        /// <summary>
        /// Load all the dependencies of the application by layer
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            // Api Setup
            services.AddApiServices();

            return services;
        }
    }
}
