using System;

namespace TemplateMethod.Contracts;

internal abstract class OrderTemplate
{
    public abstract void Basket();
    public abstract void Payment();
    public abstract void Delivery();
    public static void AddGift() => Console.WriteLine("Added gift for order...");

    public void ProcessOrder(bool withGift)
    {
        Basket();
        Payment();
        if (withGift)
            AddGift();
        Delivery();
    }
}

