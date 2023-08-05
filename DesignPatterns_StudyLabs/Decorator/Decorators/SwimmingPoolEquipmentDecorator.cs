using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class SwimmingPoolEquipmentDecorator : BaseEquipmentDecorator
{
    public SwimmingPoolEquipmentDecorator(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment($"\t\t{nameof(SwimmingPoolEquipmentDecorator)}:");
        exercise.AddEquipment("\t\t\tflip flops");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm going to swim");
        base.Execute();
    }
}
