using Searcher.Commands;
using Searcher.Models;
using System.Collections.ObjectModel;

namespace Searcher.ViewModels;

public class PersonViewModel<PersonType> : BaseViewModel
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
    private PersonType? _selectedTeacher;
    public PersonType? SelectedTeacher
    {
        get => _selectedTeacher;
        set
        {
            _selectedTeacher = value;
            OnPropertyChanged();
        }
    }
    private ObservableCollection<PersonType> _personCollection = new();
    public ObservableCollection<PersonType> PersonCollection
    {
        get => _personCollection;
        set
        {
            _personCollection = value;
            OnPropertyChanged();
        }
    }
    public BaseCommand SearchCommand { get; }
    public BaseCommand ClearCommand { get; }
    public PersonViewModel()
    {
        SearchCommand = new SearchCommand<PersonType>(this);
        ClearCommand = new ClearCommand<PersonType>(this);
    }
}