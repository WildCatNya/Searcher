using Searcher.Commands;
using Searcher.Commands.Teacher;
using Searcher.Models;
using System.Collections.ObjectModel;

namespace Searcher.ViewModels;

public class TeacherViewModel : BaseViewModel
{
    private string? _searcher;
    public string? Searcher
    {
        get => _searcher;
        set
        {
            _searcher = value;
            OnPropertyChanged();
        }
    }
    private Teacher? _selectedTeacher;
    public Teacher? SelectedTeacher
    {
        get => _selectedTeacher;
        set
        {
            _selectedTeacher = value;
            OnPropertyChanged();
        }
    }
    private ObservableCollection<Teacher> _teachers = new();
    public ObservableCollection<Teacher> Teachers
    {
        get => _teachers;
        set
        {
            _teachers = value;
            OnPropertyChanged();
        }
    }
    public BaseCommand SearchCommand { get; }
    public BaseCommand ClearCommand { get; }
    public BaseCommand NavigateStudentCommand { get; }
    public TeacherViewModel()
    {
        SearchCommand = new SearchTeacherCommand(this);
        ClearCommand = new ClearTeacherCommand(this);
        NavigateStudentCommand = new NavigateCommand(() => new StudentViewModel());
    }
}