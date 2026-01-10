using Microsoft.Extensions.DependencyInjection;

namespace WPF.MVVM.Starter.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        private readonly IServiceProvider _serviceProvider;

        public NavigationService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TViewModel NavigateTo<TViewModel>() where TViewModel : class
        {
            return _serviceProvider.GetRequiredService<TViewModel>();
        }
    }
}
