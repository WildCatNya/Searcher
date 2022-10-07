using Searcher.Commands;
using Searcher.Helpers;
using Searcher.Models;
using System.Collections.ObjectModel;

namespace Searcher.ViewModels;

public class StudentViewModel : BaseViewModel
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
    private Student? _selectedStudent;
    public Student? SelectedStudent
    {
        get => _selectedStudent;
        set
        {
            _selectedStudent = value;
            OnPropertyChanged();
        }
    }
    private ObservableCollection<Student> _students = new();
    public ObservableCollection<Student> Students
    {
        get => _students;
        set
        {
            _students = value;
            OnPropertyChanged();
        }
    }
    public BaseCommand SearchCommand { get; }
    public BaseCommand ClearCommand { get; }
    public BaseCommand NavigateTeacherCommand { get; }
    public StudentViewModel()
    {
        SearchCommand = new SearchStudentCommand(this);
        ClearCommand = new ClearStudentCommand(this);
        NavigateTeacherCommand = new NavigateCommand(() => new TeacherViewModel());
    }
}