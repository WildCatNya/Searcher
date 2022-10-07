using StudentSearch.ViewModels;
using System;

namespace StudentSearch;

public class NavigationStore
{
    private static NavigationStore? _navigationStore;
    public static NavigationStore GetNavigationStore() => _navigationStore ??= new();
    private NavigationStore() { }
    private BaseViewModel _currentViewModel;
    public event Action CurrentViewModelChanged;
    public BaseViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }
    private void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}
