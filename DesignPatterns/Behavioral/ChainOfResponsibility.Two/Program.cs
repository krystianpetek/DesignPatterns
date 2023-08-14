using System;
using ChainOfResponsibility.Two.Contracts;
using ChainOfResponsibility.Two.Entities;
using ChainOfResponsibility.Two.Entities.Notifications;

namespace ChainOfResponsibility.Two;

public static class Program
{
    public static void Main()
    {
        IChain l1 = new EmptyNotifications();
        IChain l2 = new SmallNotifications();
        IChain l3 = new HighNotifications();
        l1.SetNext(l2);
        l2.SetNext(l3);
        
        l1.Handle(new NotificationList(0));
        l1.Handle(new NotificationList(1));
        l1.Handle(new NotificationList(12));
        l1.Handle(new NotificationList(3));
        l1.Handle(new NotificationList(0));
    }
}