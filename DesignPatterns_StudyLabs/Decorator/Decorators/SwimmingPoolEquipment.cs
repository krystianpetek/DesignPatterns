using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class SwimmingPoolEquipment : ExerciseEquipmentDecorator
{
    public SwimmingPoolEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("flip flops");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm about to swim");
        base.Execute();
    }
}
