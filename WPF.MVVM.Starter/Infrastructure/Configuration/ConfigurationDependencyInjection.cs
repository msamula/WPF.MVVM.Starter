using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WPF.MVVM.Starter.Infrastructure.Configuration.Settings;

namespace WPF.MVVM.Starter.Infrastructure.Configuration
{
    public static class ConfigurationDependencyInjection
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));

            return services;
        }
    }
}
