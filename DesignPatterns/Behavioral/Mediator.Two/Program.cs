using Mediator.Two.Contracts;
using Mediator.Two.Mediator;
using Mediator.Two.Notifications;

namespace Mediator.Two;

public static class Program
{
    public static void Main()
    {
        IMediator mediator = new NotificationMediator(new GlobalNotification(), new LocalNotification());
        
        mediator.Notify("globalNotification");
        mediator.Notify("localNotification");
    }
}