using System.Diagnostics.CodeAnalysis;

namespace Api.Configurations
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationService
    {
        public static IServiceCollection AddAplications(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddRules(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddExternalServices(this IServiceCollection services, IConfiguration configuration)
        {

            return services;
        }

        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddCache(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }

        public static IServiceCollection AddConsumers(this IServiceCollection services)
        {
            return services;
        }
    }
}
