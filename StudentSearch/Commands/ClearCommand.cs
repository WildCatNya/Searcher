﻿using StudentSearch.ViewModels;
using System;
using System.ComponentModel;
using System.Linq;

namespace StudentSearch.Commands;

public class ClearCommand : BaseCommand
{
    private readonly StudentViewModel _vm;
    public ClearCommand(StudentViewModel vm)
    {
        _vm = vm;
        _vm.PropertyChanged += OnViewModelPropertyChange;
    }
    public override bool CanExecute(object? parameter)
    {
        return _vm.Students.Count > 0;
    }
    public override void Execute(object? parameter)
    {
        _vm.Students = new();
        _vm.Searcher = string.Empty;
    }
    private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(_vm.Students))
        {
            OnCanExecuteChanged();
        }
    }
}