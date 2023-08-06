using System.Collections.Generic;

namespace Facade.Repositories;

class UserRepository
{
    private readonly List<string> _users;

    public UserRepository()
    {
        _users = new List<string>()
        {
            "john.doe@gmail.com",
            "sylvester.stallone@gmail.com"
        };
    }

    public bool IsEmailFree(string email)
    {
        if (_users.Contains(email)) return false;
        else return true;
    }

    public void AddUser(string email)
    {
        _users.Add(email);
    }

    public void RemoveUser(string email)
    {
        _users.Remove(email);
    }

    public List<string> Users => _users;
}
