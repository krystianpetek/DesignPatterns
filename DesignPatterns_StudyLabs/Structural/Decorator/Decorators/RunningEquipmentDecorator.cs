using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class RunningEquipmentDecorator : BaseEquipmentDecorator
{
    public RunningEquipmentDecorator(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment($"\t\t{nameof(RunningEquipmentDecorator)}:");
        exercise.AddEquipment("\t\t\tshoes");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm going to run");
        base.Execute();
    }
}
