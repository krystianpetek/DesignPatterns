using System;
using Interpreter.Two.Contexts;
using Interpreter.Two.Contracts;

namespace Interpreter.Two;

public static class Program
{
    public static void Main()
    {
        Context appContext = new Context("425 11 3 + /");
        appContext = new Context("5 42 10 - +");
        
        IOperation result = appContext.Interpreter();
        Console.WriteLine(result.Interpreter());
    }
}
