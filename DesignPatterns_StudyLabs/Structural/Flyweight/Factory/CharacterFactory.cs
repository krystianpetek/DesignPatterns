using System;
using System.Collections.Generic;
using Flyweight.Entity;

namespace Flyweight.Factory;

public class CharacterFactory
{
    private readonly Dictionary<string, Character> _characters;
    public CharacterFactory()
    {
        _characters = new Dictionary<string, Character>();
    }

    public Character AddCharacter(string name, int level, float maxHp)
    {
        string uniqueCharacterKey = Character.GetKey(name, level, maxHp);
        
        if (!_characters.ContainsKey(uniqueCharacterKey))
            _characters.Add(uniqueCharacterKey, new Character(name, level, maxHp));

        return _characters[uniqueCharacterKey];
    }

    public void EnumerateCharacters()
    {
        foreach (var character in _characters)
            Console.WriteLine(character.Value.Display());
    }
}
