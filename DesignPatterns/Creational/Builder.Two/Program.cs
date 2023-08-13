using Builder.Two.Builders;
using Builder.Two.Contracts;
using System;

namespace Builder.Two;

public static class Program
{
    public static void Main()
    {
        BuildDirector buildDirector = new BuildDirector();
        IBuilder builder = new FirstProductBuilder();
        
        Console.WriteLine("Poor product: ");
        buildDirector.BuildPoorProduct();
        builder.GetProduct();

        Console.WriteLine("Rich product: ");
        buildDirector.BuildRichProduct();
        builder.GetProduct();

        Console.WriteLine("Custom product: ");
        builder.BuildA();
        builder.BuildC();
        builder.GetProduct();
    }
}
