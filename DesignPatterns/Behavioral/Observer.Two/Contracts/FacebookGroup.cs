using System.Collections.Generic;

namespace Observer.Two.Contracts;

public abstract class FacebookGroup
{
    private string _newPost;
    private readonly List<IUser> _users;

    protected FacebookGroup()
    {
        _newPost = string.Empty;
        _users = new List<IUser>();
    }

    public string Post
    {
        get => _newPost;
        set
        {
            _newPost = value;
            Notification();
        }
    }
    public void Subscribe(IUser user)
    {
        _users.Add(user);
    }
    public void Unsubscribe(IUser user)
    {
        _users.Remove(user);
    }
    public void Notification()
    {
        foreach (var user in _users)
            user.NotifyUser(this);
    }
}
