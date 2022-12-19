using Application.Application;
using Business;
using Domain.Adapter;
using Domain.Business;
using Repository;
using System.Diagnostics.CodeAnalysis;

namespace Api.Configurations
{
    [ExcludeFromCodeCoverage]
    public static class ConfigurationService
    {
        public static IServiceCollection AddAplications(this IServiceCollection services)
        {
            services.AddTransient<IContactApplication, ContactApplication>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IContactAdapter, ContactAdapter>();
            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddTransient<IContactBusiness, ContactBusiness>();
            return services;
        }
    }
}
