namespace StudentSearch.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    public MainWindowViewModel()
    {
        _navigationStore = NavigationStore.GetNavigationStore();
        _navigationStore.CurrentViewModel = new StudentViewModel();
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }
    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;
    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}