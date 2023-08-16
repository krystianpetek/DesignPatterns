using Interpreter.Two.Contracts;

namespace Interpreter.Two.Operations;

public class CommonNumber : IOperation
{
    private readonly int _number;
    public CommonNumber(int number)
    {
        _number = number;
    }
    public int Interpreter()
    {
        return _number;
    }
}
