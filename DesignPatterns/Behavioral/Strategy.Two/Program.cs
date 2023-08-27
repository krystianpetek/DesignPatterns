using System;
using Strategy.Two.Contracts;
using Strategy.Two.Strategies;

namespace Strategy.Two;

public static class Program
{
    public static void Main()
    {
        IOperation operation = new Addition();
        double result = operation.ExecuteOperation(1, 5);
        operation = new Modulo();
        Console.WriteLine(result);

        result = operation.ExecuteOperation(4, 3);
        Console.WriteLine(result);
    }
}
