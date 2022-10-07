using StudentSearch.ViewModels;
using System;

namespace StudentSearch.Commands;

public class NavigateCommand : BaseCommand
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<BaseViewModel> _creteViewModel;
    public NavigateCommand(Func<BaseViewModel> creteViewModel)
    {
        _navigationStore = NavigationStore.GetNavigationStore();
        _creteViewModel = creteViewModel;
    }
    public override void Execute(object parameter)
    {
        _navigationStore.CurrentViewModel = _creteViewModel();
    }
}