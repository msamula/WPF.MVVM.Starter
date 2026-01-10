using Microsoft.Extensions.DependencyInjection;
using WPF.MVVM.Starter.Services.Navigation;
using WPF.MVVM.Starter.ViewModels;
using WPF.MVVM.Starter.Views;

namespace WPF.MVVM.Starter.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAplicationServices(this IServiceCollection services)
        {
            services.AddViews();
            services.AddViewModels();
            services.AddServices();

            return services;
        }

        private static IServiceCollection AddViews(this IServiceCollection services)
        {
            services.AddSingleton<MainWindow>();

            return services;
        }

        private static IServiceCollection AddViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();

            return services;
        }

        private static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<INavigationService, NavigationService>();

            return services;
        }
    }
}
