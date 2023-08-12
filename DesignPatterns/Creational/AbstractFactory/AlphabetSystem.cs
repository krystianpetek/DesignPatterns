using AbstractFactory.Contracts;
using System;

namespace AbstractFactory;

class AlphabetSystem
{
    private readonly IAlphabetFactory _alphabetFactory;
    private readonly ILetter _letters;
    private readonly INumber _numbers;

    public AlphabetSystem(IAlphabetFactory alphabetFactory)
    {
        _alphabetFactory = alphabetFactory;
        _letters = _alphabetFactory.CreateLetters();
        _numbers = _alphabetFactory.CreateNumbers();
    }

    public void Display() => Console.WriteLine($"{_alphabetFactory.GetType().Name}: {_letters.DisplayLetters()} {_numbers.DisplayNumbers()}");
}
