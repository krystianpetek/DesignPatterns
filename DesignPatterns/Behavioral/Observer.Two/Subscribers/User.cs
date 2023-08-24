using System;
using Observer.Two.Contracts;

namespace Observer.Two.Subscribers;

public class User : IUser
{
    private readonly string _name;
    public User(string name)
    {
        _name = name;
    }

    public void NotifyUser(FacebookGroups group)
    {
        Console.WriteLine($"{_name}: added new post: {group.Post}");
    }
}
