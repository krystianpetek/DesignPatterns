using State.Two.StateHolder;
using System;

namespace State.Two;

public static class Program
{
    public static void Main()
    {
        var machine = new StateMachine();
        Console.WriteLine("maszyna z produkatami");
        Console.WriteLine("1. Wrzuć monete");
        Console.WriteLine("2. Zwroc monete");
        Console.WriteLine("3. Wciśnij przycisk");
        Console.WriteLine("4. Wyłącz");

        while (true)
        {
            Console.WriteLine("Wprowadz komende");
            string komenda = Console.ReadLine();
            switch (komenda)
            {
                case "1":
                    machine.PutCoin();
                    break;
                case "2":
                    machine.ReturnCoin();
                    break;
                case "3":
                    machine.PushButton();
                    break;
                default: break;
            }
        }
    }
}
