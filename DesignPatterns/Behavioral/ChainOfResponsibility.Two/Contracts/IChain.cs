using ChainOfResponsibility.Two.Entities;

namespace ChainOfResponsibility.Two.Contracts;

public interface IChain
{
    public void Handle(NotificationList notifications);
    public void SetNext(IChain nextHandle);
}