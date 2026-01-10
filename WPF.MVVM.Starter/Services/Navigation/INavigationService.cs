namespace WPF.MVVM.Starter.Services.Navigation
{
    public interface INavigationService
    {
        TViewModel NavigateTo<TViewModel>() where TViewModel : class;
    }
}
