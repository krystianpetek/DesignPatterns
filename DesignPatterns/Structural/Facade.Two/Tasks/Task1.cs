using System;
using Facade.Two.Contracts;

namespace Facade.Two.Tasks;

public class Task1 : ITask
{
    public void Execute()
    {
        Console.WriteLine("Zadanie1");
    }
}
