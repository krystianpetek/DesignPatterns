using System;
using Mediator.Two.Contracts;

namespace Mediator.Two.Notifications;

public class LocalNotification : BaseNotify
{
    public override void Notify() => Console.WriteLine("LOCAL NOTIFICATION");
}
