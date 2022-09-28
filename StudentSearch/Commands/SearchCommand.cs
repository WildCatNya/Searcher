using StudentSearch.Models;
using StudentSearch.ViewModels;
using System.Linq;

namespace StudentSearch.Commands;

public class SearchCommand : BaseCommand
{
    private readonly StudentViewModel _vm;
    public SearchCommand(StudentViewModel vm)
    {
        _vm = vm;
    }
    public override void Execute(object? parameter)
    {
        _vm.Students = new(Student.GetStudents().Where(x => Contain(x)));
    }
    private bool Contain(Student x)
    {
        return x.FIO.ToLower().Contains(_vm.FioSearch.ToLower());
    }
}