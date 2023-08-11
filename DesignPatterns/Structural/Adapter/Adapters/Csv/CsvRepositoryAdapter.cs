using System.Collections.Generic;
using Adapter.Contracts;

namespace Adapter.Adapters.Csv;

public class CsvRepositoryAdapter : IRepositoryAdapter
{
    private readonly CsvService _csvService;
    
    public CsvRepositoryAdapter(CsvService csvService)
    {
        _csvService = csvService;
    }

    public List<string> GetUserNames()
    {
        string incompatibleApiResponse = _csvService.GetUsersFromCsv;
        string[] splitUsersPerLine = incompatibleApiResponse.Split("\n");

        List<string> users = new List<string>();
        foreach (string user in splitUsersPerLine)
        {
            string[] usersNameAndSurname = user.Split(",");
            users.Add(usersNameAndSurname[0] + " " + usersNameAndSurname[1]);
        }

        return users;
    }
}
