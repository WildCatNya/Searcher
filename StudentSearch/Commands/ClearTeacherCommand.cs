using Searcher.ViewModels;
using System.ComponentModel;

namespace Searcher.Commands;

public class ClearTeacherCommand : BaseCommand
{
    private readonly TeacherViewModel _vm;
    public ClearTeacherCommand(TeacherViewModel vm)
    {
        _vm = vm;
        _vm.PropertyChanged += OnViewModelPropertyChange;
    }
    public override bool CanExecute(object? parameter)
    {
        return _vm.Teachers.Count > 0;
    }
    public override void Execute(object? parameter)
    {
        _vm.Teachers = new();
        _vm.Searcher = string.Empty;
    }
    private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
    {
        //if (e.PropertyName == nameof(_vm.Students))
        //{
        //    OnCanExecuteChanged();
        //}
        OnCanExecuteChanged();
    }
}