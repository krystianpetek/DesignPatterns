using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class RunningEquipment : ExerciseEquipmentDecorator
{
    public RunningEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("shoes");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm about to run");
        base.Execute();
    }
}
