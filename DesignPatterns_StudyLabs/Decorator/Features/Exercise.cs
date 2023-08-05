using System;
using System.Collections.Generic;
using Decorator.Contracts;

namespace Decorator.Features;

public class Exercise : IExercise
{
    public List<string> RequiredEquipment { get; }

    public Exercise()
    {
        RequiredEquipment = new List<string>();
    }

    public void AddEquipment(string equipmentName) => RequiredEquipment.Add(equipmentName);
    public void Execute()
    {
        Console.WriteLine("I need to pack:");
        RequiredEquipment.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("Starting exercise");
    }
}
