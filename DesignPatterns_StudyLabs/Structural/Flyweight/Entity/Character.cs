namespace Flyweight.Entity;

public class Character
{
    private readonly SharedCharacter _character;

    public Character(string name, int level, float maxHp)
    {
        _character = new SharedCharacter(name, maxHp, level, 1.0);
    }

    public static string GetKey(string name, int level, float maxHp) => name + "_" + level + "_" + maxHp;
    public string Display() => $"{_character}";
}
