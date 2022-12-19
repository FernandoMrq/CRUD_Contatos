using Microsoft.EntityFrameworkCore;
using Repository;

namespace Api.Configurations
{
    public static class ConfigureDatabase
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ContactConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));

            return services;
        }
    }
}
