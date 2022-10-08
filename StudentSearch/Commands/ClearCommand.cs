using Searcher.ViewModels;
using System.ComponentModel;

namespace Searcher.Commands;

public class ClearCommand<PersonType> : BaseCommand
{
    private readonly PersonViewModel<PersonType> _vm;
    public ClearCommand(PersonViewModel<PersonType> vm)
    {
        _vm = vm;
        _vm.PropertyChanged += OnViewModelPropertyChange;
    }
    public override bool CanExecute(object? parameter)
    {
        return _vm.PersonCollection.Count > 0;
    }
    public override void Execute(object? parameter)
    {
        _vm.PersonCollection = new();
        _vm.Searcher = string.Empty;
    }
    private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_vm.PersonCollection))
        {
            OnCanExecuteChanged();
        }
    }
}