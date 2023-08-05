using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class GolfEquipmentDecorator : BaseEquipmentDecorator
{
    public GolfEquipmentDecorator(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment($"\t\t{nameof(GolfEquipmentDecorator)}:");
        exercise.AddEquipment("\t\t\tgolf club");
        exercise.AddEquipment("\t\t\tballs");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm going to play golf");
        base.Execute();
    }
}
