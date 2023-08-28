using System.Collections.Generic;
using Visitor.Cities;
using Visitor.Contracts;
using Visitor.Extensions;
using Visitor.Visitor;

namespace Visitor;

public static class Program
{
    public static void Main()
    {
        List<ICity> components = new List<ICity>()
        {
            new PolishCity("Kraków"),
            new PolishCity("Szczecin"),
            new PolishCity("Rzeszów"),
            new PolishCity("Gdańsk"),
            new PolishCity("Katowice"),
            new NetherlandCity("Maastricht"),
            new NetherlandCity("Amsterdam"),
            new UsaCity("Nowy Jork"),
            new UsaCity("Waszyngton"),
            new UsaCity("Boston"),
            new UsaCity("Princeton"),
            new UsaCity("Seattle"),
            new UsaCity("Chicago"),
            new UsaCity("Huston"),
        };

        IVisitor visitor = new Visitor.Visitor();
        components.ClientCode(visitor);
        visitor.PrintInfo();
    }
}