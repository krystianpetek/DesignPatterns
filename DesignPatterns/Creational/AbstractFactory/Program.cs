using AbstractFactory.Factories;
using System;
using System.Text;

namespace AbstractFactory;

public static class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        AlphabetSystem lacinkaAlphabet = new AlphabetSystem(new LacinkaFactory());
        lacinkaAlphabet.Display();
        
        AlphabetSystem cyrylicaAlphabet = new AlphabetSystem(new CyrylicaFactory());
        cyrylicaAlphabet.Display();
        
        AlphabetSystem grekaAlphabet = new AlphabetSystem(new GrekaFactory());
        grekaAlphabet.Display();
    }
}