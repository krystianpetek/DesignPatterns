using Iterator.Contracts;

namespace Iterator.Iterators;

public class OnlyWeekDaysIterator : IWeeksIterator
{
    private readonly string[] _weeks;
    private int _position;

    public OnlyWeekDaysIterator(string[] weeks)
    {
        _weeks = weeks;
        _position = -1;
    }

    public string CurrentItem => _weeks[_position];

    public bool MoveNext()
    {
        if (_position < _weeks.Length - 3)
        {
            _position++;
            return true;
        }
        return false;
    }
}