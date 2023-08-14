using ChainOfResponsibility.Two.Entities;

namespace ChainOfResponsibility.Two.Contracts;

public abstract class ChainNotifications : IChain
{
    protected IChain _nextHandle;
    public void SetNext(IChain nextHandle) => _nextHandle = nextHandle;
    public abstract void Handle(NotificationList notifications);
}