using Searcher.Helpers;
using System.Windows;

namespace Searcher.ViewModels;

public class MainWindowViewModel : BaseViewModel
{
    private readonly NavigationStore _navigationStore;
    public MainWindowViewModel()
    {
        _navigationStore = NavigationStore.GetNavigationStore();
        _navigationStore.CurrentViewModel = new StudentViewModel();
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
        if (_navigationStore.CurrentViewModel.ToString().Contains(nameof(StudentViewModel)))
        {
            Title = "Поиск студентов";
        }
        if (_navigationStore.CurrentViewModel.ToString().Contains(nameof(TeacherViewModel)))
        {
            Title = "Поиск преподавателей";
        }
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}