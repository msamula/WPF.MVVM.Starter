using CommunityToolkit.Mvvm.ComponentModel;

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

        public MainWindowViewModel()
        {
            ApplicationTitle = "WPF MVVM Starter";
        }
    }
}
