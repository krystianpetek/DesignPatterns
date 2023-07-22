using strategy.Interfaces;

namespace strategy.EventParsers;

public class SecondParseStrategy : IParseEventStrategy
{
    public string Parse()
    {
        string strategy = "SecondParseStrategy";
        Console.WriteLine(strategy);
        return strategy;
    }
}
