using System;
using System.Collections.Generic;
using Interpreter.Contexts;
using Interpreter.Contracts;
using Interpreter.Phrases;

namespace Interpreter;

public static class Program
{
    public static void Main()
    {
        List<Phrase> tree = new List<Phrase>
        {
            new PhraseThousands(),
            new PhraseHundreds(),
            new PhraseTens(),
            new PhraseOnes()
        };

        string roman = "MDXLIII";
        Context context = new Context(roman);
        foreach (Phrase item in tree)
        {
            item.Interpreter(context);
        }
        Console.WriteLine(roman + " = " + context.Output);
        // MDXLIII = 1543

        roman = "CMXVII";
        context = new Context(roman);
        foreach (Phrase item in tree)
        {
            item.Interpreter(context);
        }
        Console.WriteLine(roman + " = " + context.Output);
        // CMXVII = 917

    }
}