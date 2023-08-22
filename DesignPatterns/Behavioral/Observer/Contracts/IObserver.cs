namespace Observer.Contracts;

public interface IObserver
{
    void Update(ISubject subject);
}