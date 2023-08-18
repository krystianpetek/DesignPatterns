using System;
using Mediator.Two.Contracts;

namespace Mediator.Two.Notifications;

public class GlobalNotification : BaseNotify
{
    public override void Notify() => Console.WriteLine("GLOBAL NOTIFICATION");
}
