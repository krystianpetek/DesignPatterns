using AbstractFactory.Contracts;

namespace AbstractFactory.Factories;

class GrekaFactory : IAlphabetFactory
{
    public ILetter CreateLetters() => new GrekaLetters();
    public INumber CreateNumbers() => new GrekaNumbers();
}

class GrekaNumbers : INumber
{
    private readonly string _numbers;

    public GrekaNumbers() => _numbers = "αʹ βʹ γʹ";
    public string DisplayNumbers() => _numbers;
}

class GrekaLetters : ILetter
{
    private readonly string _letters;

    public GrekaLetters() => _letters = "αβγδε";
    public string DisplayLetters() => _letters;
}