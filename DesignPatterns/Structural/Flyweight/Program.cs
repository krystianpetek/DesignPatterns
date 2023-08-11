using Flyweight.Factory;

namespace Flyweight;

public static class Program
{
    public static void Main()
    {
        CharacterFactory factory = new CharacterFactory();
        factory.AddCharacter("Geralt", 1, 300);
        factory.AddCharacter("Geralt", 1, 300);
        factory.AddCharacter("Yennefer", 3, 300);

        factory.EnumerateCharacters();
    }
}
