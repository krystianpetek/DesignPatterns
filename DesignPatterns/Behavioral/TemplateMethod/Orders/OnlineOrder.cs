using System;
using TemplateMethod.Contracts;

namespace TemplateMethod.OrderTypes;

internal class OnlineOrder : OrderTemplate
{
    override public void Basket()
    {
        Console.WriteLine("Kompletowanie zamówienia...");
        Console.WriteLine("Ustawiono parametry wysyłki...");
    }

    public override void Payment() => Console.WriteLine("Płatność...");
    public override void Delivery() => Console.WriteLine("Wysyłka...");
}

