using System;

namespace TemplateMethod.Two.Contracts;

public abstract class CreateHuman
{
    public abstract void Plec();
    public static void Glowa() => Console.WriteLine("Głowa");
    public virtual void Wlosy() => Console.WriteLine("Bez włosów");
    public static void Rece() => Console.WriteLine("Ręce");
    public static void Tulow() => Console.WriteLine("Tułów");
    public static void Nogi() => Console.WriteLine("Nogi");

    public void Create()
    {
        Plec();
        Glowa();
        Wlosy();
        Rece();
        Tulow();
        Nogi();
    }
}
