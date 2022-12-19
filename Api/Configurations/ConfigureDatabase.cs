using Microsoft.EntityFrameworkCore;
using Repository;

namespace Api.Configurations
{
    public static class ConfigureDatabase
    {
        public static void ConfigureDatabaseServices(IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("ContactConnection");
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connection));
        }
    }
}
