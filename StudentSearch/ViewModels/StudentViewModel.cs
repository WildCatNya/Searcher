using StudentSearch.Commands;
using StudentSearch.Models;
using System.Collections.ObjectModel;

namespace StudentSearch.ViewModels;

public class StudentViewModel : BaseViewModel
{
    private string? _searcher;
    public string? Searcher
    {
        get => _searcher;
        set
        {
            _searcher = value;
            OnPropertyChanged(nameof(Searcher));
        }
    }
    private Student? _selectedStudent;
    public Student? SelectedStudent
    {
        get => _selectedStudent;
        set
        {
            _selectedStudent = value;
            OnPropertyChanged(nameof(SelectedStudent));
        }
    }
    private ObservableCollection<Student>? _students;
    public ObservableCollection<Student>? Students
    {
        get => _students;
        set
        {
            _students = value;
            OnPropertyChanged(nameof(Students));
        }
    }
    public BaseCommand SearchCommand { get; }
    public StudentViewModel()
    {
        SearchCommand = new SearchCommand(this); 
    }
}