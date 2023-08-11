namespace Flyweight.Entity;

internal class SharedCharacter
{
    private readonly string _name;
    private readonly float _maxHp;
    private readonly int _level;
    private readonly double _speed;

    public SharedCharacter(string name, float maxHp, int level, double speed)
    {
        _name = name;
        _maxHp = maxHp;
        _level = level;
        _speed = speed;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Level: {_level}, Maximum HP: {_maxHp}, Speed: {_speed}";
    }
}
