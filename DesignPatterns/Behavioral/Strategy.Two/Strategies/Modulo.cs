using Strategy.Two.Contracts;

namespace Strategy.Two.Strategies;

public class Modulo : IOperation
{
    public double ExecuteOperation(int a, int b)

    {
        return a % b;
    }
}
