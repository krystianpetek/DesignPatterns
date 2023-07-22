using strategy.Interfaces;

namespace strategy.EventParsers;

public class FirstParseStrategy : IParseEventStrategy
{
    public string Parse()
    {
        string strategy = "FirstParseStrategy";
        Console.WriteLine(strategy);
        return strategy;
    }
}
