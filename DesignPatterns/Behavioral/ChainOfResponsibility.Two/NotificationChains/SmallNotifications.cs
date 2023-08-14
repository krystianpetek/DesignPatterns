using System;
using ChainOfResponsibility.Two.Contracts;

namespace ChainOfResponsibility.Two.Entities.Notifications;

public class SmallNotifications : ChainNotifications
{
    public override void Handle(NotificationList notifications)
    {
        if (notifications.GetNumber() <= 5)
            Console.WriteLine("Small amount of notifications: " + notifications.GetNumber());
        else
            _nextHandle.Handle(notifications);
    }
}