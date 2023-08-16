using Interpreter.Two.Contracts;

namespace Interpreter.Two.Operations;

public class Addition : IOperation
{
    private readonly IOperation _left;
    private readonly IOperation _right;
    
    public Addition(IOperation left, IOperation right)
    {
        _left = left;
        _right = right;
    }

    public int Interpreter()
    {
        return _left.Interpreter() + _right.Interpreter();
    }
}
