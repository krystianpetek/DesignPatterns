using System;
using Iterator.Collection;
using Iterator.Contracts;

namespace Iterator;

public static class Program
{
    public static void Main()
    {
        WeeksCollection weeksCollection = new WeeksCollection();
        IWeeksIterator iterator = weeksCollection.OnlyWeekDaysIterator();
        Console.WriteLine("Only week days iterator");
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.CurrentItem);
        }

        Console.WriteLine();

        Console.WriteLine("All days iterator");
        iterator = weeksCollection.WeeksIterator();
        while (iterator.MoveNext())
        {
            Console.WriteLine(iterator.CurrentItem);
        }
    }
    
}
