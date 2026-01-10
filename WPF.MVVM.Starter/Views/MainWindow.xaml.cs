using System.Windows;
using WPF.MVVM.Starter.ViewModels;

namespace WPF.MVVM.Starter.Views
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel? ViewModel => DataContext as MainWindowViewModel;

        public MainWindow(MainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();
            DataContext = mainWindowViewModel;
        }
    }
}
