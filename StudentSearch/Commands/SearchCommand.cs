using Searcher.ViewModels;
using System;
using System.ComponentModel;

namespace Searcher.Commands;

public class SearchCommand<PersonType> : BaseCommand
{
    private readonly PersonViewModel<PersonType> _vm;
    public SearchCommand(PersonViewModel<PersonType> vm)
    {
        _vm = vm;
        _vm.PropertyChanged += OnViewModelPropertyChange;
    }
    public override bool CanExecute(object? parameter)
    {
        return !string.IsNullOrEmpty(_vm.Searcher);
    }
    public override void Execute(object? parameter)
    {
        throw new NotImplementedException();
    }
    private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_vm.Searcher))
        {
            OnCanExecuteChanged();
        }
    }
}