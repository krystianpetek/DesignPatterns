using System;
using ChainOfResponsibility.Two.Contracts;

namespace ChainOfResponsibility.Two.Entities.Notifications;

public class HighNotifications : ChainNotifications
{
    public override void Handle(NotificationList notifications)
    {
        Console.WriteLine($"Duzo powiadomień: {notifications.GetNumber()}");
    }
}