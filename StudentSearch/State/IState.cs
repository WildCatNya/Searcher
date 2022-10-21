using System.Collections.Generic;

namespace Searcher.State;

public interface IState<PersonType>
{
    IEnumerable<PersonType> Search();
    void Clear();
}