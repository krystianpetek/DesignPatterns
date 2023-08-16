using System.Collections.Generic;
using Interpreter.Two.Contracts;
using Interpreter.Two.Operations;

namespace Interpreter.Two.Contexts;

public class Context
{
    private readonly string[] _splittedText;
    public Context(string line)
    {
        _splittedText = line.Split(" ");
    }
    public IOperation Interpreter()
    {
        Stack<IOperation> operations = new Stack<IOperation>();
        foreach (var x in _splittedText)
        {
            IOperation leftOperation;
            IOperation rightOperation;
            switch (x)
            {
                case "+":
                    rightOperation = operations.Pop();
                    leftOperation = operations.Pop();
                    operations.Push(new Addition(leftOperation, rightOperation));
                    break;
                case "-":
                    rightOperation = operations.Pop();
                    leftOperation = operations.Pop();
                    operations.Push(new Subtraction(leftOperation, rightOperation));
                    break;
                case "*":
                    rightOperation = operations.Pop();
                    leftOperation = operations.Pop();
                    operations.Push(new Multiplication(leftOperation, rightOperation));
                    break;
                case "/":
                    rightOperation = operations.Pop();
                    leftOperation = operations.Pop();
                    operations.Push(new Division(leftOperation, rightOperation));
                    break;
                case "%":
                    rightOperation = operations.Pop();
                    leftOperation = operations.Pop();
                    operations.Push(new Modulo(leftOperation, rightOperation));
                    break;
                default:
                    int liczba = int.Parse(x);
                    operations.Push(new CommonNumber(liczba));
                    break;
            }
        }
        return operations.Pop();
    }
}
