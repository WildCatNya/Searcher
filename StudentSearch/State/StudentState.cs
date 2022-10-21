using Searcher.Models;
using System.Collections.Generic;

namespace Searcher.State;

public class StudentState : IState<Student>
{
    public void Clear()
    {
        throw new System.NotImplementedException();
    }
    public IEnumerable<Student> Search()
    {
        throw new System.NotImplementedException();
    }
}
public class TeacherState : IState<Teacher>
{
    public void Clear()
    {
        throw new System.NotImplementedException();
    }
    public IEnumerable<Teacher> Search()
    {
        throw new System.NotImplementedException();
    }
}