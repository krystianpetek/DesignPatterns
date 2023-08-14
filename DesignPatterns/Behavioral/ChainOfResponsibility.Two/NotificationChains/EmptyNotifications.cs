using System;
using ChainOfResponsibility.Two.Contracts;

namespace ChainOfResponsibility.Two.Entities.Notifications;

public class EmptyNotifications : ChainNotifications
{
    public override void Handle(NotificationList notifications)
    {
        if (notifications.GetNumber() <= 0)
            Console.WriteLine("Empty list of notifications");
        else
            _nextHandle.Handle(notifications);
    }
}