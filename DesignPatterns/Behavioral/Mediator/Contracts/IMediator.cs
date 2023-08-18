namespace Mediator.Contracts;

public interface IMediator
{
    void AddUser(IUser user);
    void NotifyUser(IUser sender, string message);
}
