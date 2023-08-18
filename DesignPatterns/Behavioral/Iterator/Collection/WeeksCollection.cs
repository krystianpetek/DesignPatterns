using Iterator.Contracts;
using Iterator.Iterators;

namespace Iterator.Collection;

public class WeeksCollection
{
    private readonly string[] _weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    public IWeeksIterator WeeksIterator() => new WeeksIterator(_weekDays);
    public IWeeksIterator OnlyWeekDaysIterator() => new OnlyWeekDaysIterator(_weekDays);
}
