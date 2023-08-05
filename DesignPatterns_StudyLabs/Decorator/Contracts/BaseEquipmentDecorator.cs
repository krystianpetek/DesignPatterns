namespace Decorator.Contracts;

public abstract class BaseEquipmentDecorator : IExercise
{
    private readonly IExercise _exercise;

    protected BaseEquipmentDecorator(IExercise exercise)
    {
        _exercise = exercise;
    }

    public virtual void Execute() => _exercise.Execute();
    public void AddEquipment(string equipmentName) => _exercise.AddEquipment(equipmentName);
}
