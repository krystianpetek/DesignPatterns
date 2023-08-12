using AbstractFactory.Contracts;

namespace AbstractFactory.Factories;

class LacinkaFactory : IAlphabetFactory
{
    public ILetter CreateLetters() => new LacinkaLetters();
    public INumber CreateNumbers() => new LacinkaNumbers();
}

class LacinkaNumbers : INumber
{
    private readonly string _numbers;

    public LacinkaNumbers() => _numbers = "I II III";
    public string DisplayNumbers() => _numbers;
}

class LacinkaLetters : ILetter
{
    private readonly string _letters;

    public LacinkaLetters() => _letters = "abcde";
    public string DisplayLetters() => _letters;
}