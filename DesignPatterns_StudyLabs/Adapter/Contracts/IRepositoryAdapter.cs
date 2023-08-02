using System.Collections.Generic;

namespace Adapter.Contracts;

public interface IRepositoryAdapter
{
    List<string> GetUserNames();
}
