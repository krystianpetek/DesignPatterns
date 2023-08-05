# Decorator pattern

## Requirement description

Instrukcje
W poniższym zadaniu próbujemy rozszerzyć działanie obiektów typu IExercise przy użyciu wzorca dekorator.

Proszę stworzyć kolejny typ dekoratora 'GolfEquipment', dodający do listy wymaganych przedmiotów piłeczki oraz kije (dwa osobne wpisy do listy).

Aby przetestować działanie stwórz trzy obiekty (przykładowo: swimming, runningAndSwimming, swimmingAndGolf) i wypisz rezultat w konsoli.

Rezultat powinien przyjąć postać:
I'm about to swim
I need to pack:
flip flops
Starting exercise

I'm about to run
I'm about to swim
I need to pack:
shoes
flip flops
Starting exercise

I'm about to swim
I'm about to play golf
I need to pack:
golf club
balls
flip flops
Starting exercise

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;

namespace ExerciseDecorator
{
    public interface IExercise
    {
        void JustDoIt();
        void AddEquipment(string equipmentName);
    }

    public class Exercise : IExercise
    {
        public List<string> _requiredEquipment = new List<string>();

        public List<string> RequiredEquipment { get => _requiredEquipment; }

        public void AddEquipment(string equipmentName) => RequiredEquipment.Add(equipmentName);

        public void JustDoIt()
        {
            Console.WriteLine("I need to pack:");
            RequiredEquipment.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("Starting exercise");
        }
    }

    public abstract class ExerciseEquipmentDecorator : IExercise
    {
        IExercise _exercise;

        public ExerciseEquipmentDecorator(IExercise exercise)
        {
            _exercise = exercise;
        }

        public virtual void JustDoIt() => _exercise.JustDoIt();

        public void AddEquipment(string equipmentName) => _exercise.AddEquipment(equipmentName);
    }

    public class RunningEquipment : ExerciseEquipmentDecorator
    {
        public RunningEquipment(IExercise exercise) : base(exercise)
        {
            exercise.AddEquipment("shoes");
        }

        public override void JustDoIt()
        {
            Console.WriteLine("I'm about to run");
            base.JustDoIt();
        }
    }

    public class SwimmingPoolEquipment : ExerciseEquipmentDecorator
    {
        public SwimmingPoolEquipment(IExercise exercise) : base(exercise)
        {
            exercise.AddEquipment("flip flops");
        }

        public override void JustDoIt()
        {
            Console.WriteLine("I'm about to swim");
            base.JustDoIt();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var runningAndSwimming = new SwimmingPoolEquipment(new RunningEquipment(new Exercise()));
            runningAndSwimming.JustDoIt();
        }
    }
}
```
