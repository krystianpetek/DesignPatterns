using System;
using Visitor.Cities;
using Visitor.Contracts;

namespace Visitor.Visitor;

internal class Visitor : IVisitor
{
    private int PolishCounter = 0;
    private int NetherlandCounter = 0;
    private int UsaCounter = 0;

    public void Visit(PolishCity polishCity)
    {
        Console.WriteLine($"Odwiedzam {polishCity.City}");
        PolishCounter++;
    }
    public void Visit(NetherlandCity netherlandCity)
    {
        Console.WriteLine($"Odwiedzam {netherlandCity.City}");
        NetherlandCounter++;
    }
    public void Visit(UsaCity usaCity)
    {
        Console.WriteLine($"Odwiedzam {usaCity.City}");
        UsaCounter++;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Byłem w {PolishCounter} Polskich miastach," +
            $" {NetherlandCounter} Holenderskich miastach i {UsaCounter} miastach USA.");
    }
}
