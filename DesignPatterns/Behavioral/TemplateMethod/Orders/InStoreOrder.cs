using System;
using TemplateMethod.Contracts;

namespace TemplateMethod.OrderTypes;

internal class InStoreOrder : OrderTemplate
{
    public override void Delivery() => Console.WriteLine("Wydanie produktów (odbiór osobisty)...");
    public override void Basket() => Console.WriteLine("Wybranie produktów...");
    public override void Payment() => Console.WriteLine("Płatność w kasie (karta/gotówka)...");
}

