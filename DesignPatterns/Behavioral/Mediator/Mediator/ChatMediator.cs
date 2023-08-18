using System.Collections.Generic;
using Mediator.Contracts;

namespace Mediator.Mediator;

public class ChatMediator : IMediator
{
    private readonly List<IUser> _users;

    public ChatMediator()
    {
        _users = new List<IUser>();
    }

    public void AddUser(IUser user)
    {
        if (user != null)
            _users.Add(user);
    }

    public void NotifyUser(IUser sender, string message)
    {
        foreach (var item in _users)
        {
            if (item != sender)
                item.ReceiveMessage(message);
        }
    }
}
