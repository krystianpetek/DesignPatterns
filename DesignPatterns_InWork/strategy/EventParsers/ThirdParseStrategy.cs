using strategy.Interfaces;

namespace strategy.EventParsers;

public class ThirdParseStrategy : IParseEventStrategy
{
    public string Parse()
    {
        string strategy = "ThirdParseStrategy";
        Console.WriteLine(strategy);
        return strategy;
    }
}
