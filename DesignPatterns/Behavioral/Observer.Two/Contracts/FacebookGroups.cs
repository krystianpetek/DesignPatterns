using System.Collections.Generic;

namespace Observer.Two.Contracts;

public abstract class FacebookGroups
{
    private string _newPost;
    private readonly List<IUser> _users;

    protected FacebookGroups()
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
    public void Subscribe(IUser osoba)
    {
        _users.Add(osoba);
    }
    public void Unsubscribe(IUser osoba)
    {
        _users.Remove(osoba);
    }
    public void Notification()
    {
        foreach (var user in _users)
            user.NotifyUser(this);
    }
}
