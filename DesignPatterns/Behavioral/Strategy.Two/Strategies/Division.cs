using Strategy.Two.Contracts;

namespace Strategy.Two;

public class Division : IOperation
{
    public double ExecuteOperation(int a, int b)

    {
        return (double)a / b;
    }
}
