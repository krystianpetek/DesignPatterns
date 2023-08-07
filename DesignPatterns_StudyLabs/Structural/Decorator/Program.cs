using System;
using Decorator.Decorators;
using Decorator.Features;

namespace Decorator;

public static class Program
{
    public static void Main()
    {
        var swimming = new SwimmingPoolEquipmentDecorator(new Exercise());
        var runningAndSwimming = new SwimmingPoolEquipmentDecorator(new RunningEquipmentDecorator(new Exercise()));
        var swimmingAndGolf = new SwimmingPoolEquipmentDecorator(new GolfEquipmentDecorator(new Exercise()));
        swimming.Execute();
        Console.WriteLine();
        runningAndSwimming.Execute();
        Console.WriteLine();
        swimmingAndGolf.Execute();

    }
}