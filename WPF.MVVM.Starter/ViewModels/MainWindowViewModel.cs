using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WPF.MVVM.Starter.Infrastructure.Configuration.Settings;

namespace WPF.MVVM.Starter.ViewModels
{
    public class MainWindowViewModel : ObservableObject
    {
        private readonly ILogger<MainWindowViewModel> _logger;
        private string? _applicationTitle;

        public string? ApplicationTitle
        {
            get => _applicationTitle;
            set => SetProperty(ref _applicationTitle, value);
        }

        public MainWindowViewModel(ILogger<MainWindowViewModel> logger, IOptions<AppSettings> options)
        {
            _logger = logger;

            ApplicationTitle = options.Value.ApplicationTitle ?? "Configuration error";
            _logger.LogDebug("Application title updated to '{Title}'", ApplicationTitle);
        }
    }
}
