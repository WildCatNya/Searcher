using Searcher.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Searcher.Commands.Teacher;

public class SearchTeacherCommand : BaseCommand
{
    private readonly TeacherViewModel _vm;
    public SearchTeacherCommand(TeacherViewModel vm)
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
        IEnumerable<Models.Teacher>? searchResult = Models.Teacher.GetTeachers().Where(x => x.Contains(_vm.Searcher));
        if (!searchResult.Any())
        {
            MessageBox.Show("Ничего не найдено");
            return;
        }
        _vm.Teachers = new(searchResult);
    }
    private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
    {
        //if (e.PropertyName == nameof(_vm.Searcher))
        //{
        //    OnCanExecuteChanged();
        //}
        OnCanExecuteChanged();
    }
}