using AbstractFactory.Contracts;

namespace AbstractFactory.Factories;

class CyrylicaFactory : IAlphabetFactory
{
    public ILetter CreateLetters() => new CyrylicaLetters();
    public INumber CreateNumbers() => new CyrylicaNumbers();
}

class CyrylicaNumbers : INumber
{
    private readonly string _numbers;

    public CyrylicaNumbers() => _numbers = "1 2 3";
    public string DisplayNumbers() => _numbers;
}

class CyrylicaLetters : ILetter
{
    private readonly string _letters;

    public CyrylicaLetters() => _letters = "абвгд";
    public string DisplayLetters() => _letters;
}