using Interpreter.Two.Contracts;

namespace Interpreter.Two.Operations;

public class Division : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;

    public Division(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }
    public int Interpreter()
    {
        return _left.Interpreter() / _right.Interpreter();
    }
}
