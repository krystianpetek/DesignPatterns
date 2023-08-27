using System;
using TemplateMethod.Contracts;
using TemplateMethod.OrderTypes;

namespace TemplateMethod;

public static class Program
{
    public static void Main()
    {
        OrderTemplate onlineOrder = new OnlineOrder();
        onlineOrder.ProcessOrder(withGift: true);
        Console.WriteLine();

        OrderTemplate instoreOrder = new InStoreOrder();
        instoreOrder.ProcessOrder(withGift: false);
    }
}

