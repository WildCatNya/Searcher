using Searcher.Models;

namespace Searcher.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    public MainWindowViewModel()
    {
        _navigationStore = NavigationStore.GetNavigationStore();
        _navigationStore.CurrentViewModel = new PersonViewModel<Student>();
        _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }
    private string? _title;
    public string? Title
    {
        get => _title;
        set
        {
            _title = value;
            OnPropertyChanged();
        }
    }
    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;
    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}