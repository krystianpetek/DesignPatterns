namespace Iterator.Contracts;

public interface IWeeksIterator
{
    string CurrentItem { get; }
    bool MoveNext();
}
