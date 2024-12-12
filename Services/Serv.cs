using WebApplication9.Services;

namespace WebApplication7.Services
{
    public static class ProductServiceCollectionExtensions
    {
        public static IServiceCollection AddCVServices(this IServiceCollection services)
        {
            services.AddScoped<CVservice, CVservice>();




            return services;
        }
    }

}
