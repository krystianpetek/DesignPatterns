using System;
using Mediator.Two.Contracts;
using Mediator.Two.Notifications;

namespace Mediator.Two.Mediator;

public class NotificationMediator : IMediator
{
    private readonly GlobalNotification _global;
    private readonly LocalNotification _local;

    public NotificationMediator(GlobalNotification global, LocalNotification local)
    {
        _global = global;
        _global.SetMediator(this);

        _local = local;
        _local.SetMediator(this);
    }
    public void Notify(string message)
    {
        if (message == "globalNotification")
        {
            Console.WriteLine("Mediator reaguje na linie 'globalNotification', wywoluje powiadomienie globalne");
            _global.Notify();
        }

        if (message == "localNotification")
        {
            Console.WriteLine("Mediator reaguje na linie 'localNotification', wywoluje powiadomienie lokalne");
            _local.Notify();
        }
    }
}
