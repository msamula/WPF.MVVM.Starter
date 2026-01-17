using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Options;
using WPF.MVVM.Starter.Infrastructure.Configuration.Settings;

namespace WPF.MVVM.Starter.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private string? _applicationTitle;
        public string? ApplicationTitle
        {
            get => _applicationTitle;
            set => SetProperty(ref _applicationTitle, value);
        }

        public MainWindowViewModel(IOptions<AppSettings> options)
        {
            ApplicationTitle = options.Value.ApplicationTitle ?? "Configuration error";
        }
    }
}
