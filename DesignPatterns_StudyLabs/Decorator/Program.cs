using System;
using Decorator.Decorators;
using Decorator.Features;

namespace Decorator;

public static class Program
{
    public static void Main()
    {
        var swimming = new SwimmingPoolEquipment(new Exercise());
        var runningAndSwimming = new SwimmingPoolEquipment(new RunningEquipment(new Exercise()));
        var swimmingAndGolf = new SwimmingPoolEquipment(new GolfEquipment(new Exercise()));
        swimming.Execute();
        Console.WriteLine();
        runningAndSwimming.Execute();
        Console.WriteLine();
        swimmingAndGolf.Execute();

    }
}