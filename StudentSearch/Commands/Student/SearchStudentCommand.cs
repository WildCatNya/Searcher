﻿using Searcher.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace Searcher.Commands.Student;

public class SearchStudentCommand : BaseCommand
{
    private readonly StudentViewModel _vm;
    public SearchStudentCommand(StudentViewModel vm)
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
        IEnumerable<Models.Student>? searchResult = Models.Student.GetStudents().Where(x => x.Contains(_vm.Searcher));
        _vm.Students = new(searchResult);
        if (!searchResult.Any())
        {
            MessageBox.Show("Ничего не найдено");
        }
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