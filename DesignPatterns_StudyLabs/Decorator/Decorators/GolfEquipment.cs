using System;
using Decorator.Contracts;

namespace Decorator.Decorators;

public class GolfEquipment : ExerciseEquipmentDecorator
{
    public GolfEquipment(IExercise exercise) : base(exercise)
    {
        exercise.AddEquipment("golf club");
        exercise.AddEquipment("balls");
    }
    public override void Execute()
    {
        Console.WriteLine("I'm about to play golf");
        base.Execute();
    }
}
