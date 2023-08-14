namespace ChainOfResponsibility.Two.Entities;

public class NotificationList
{
    private readonly int _number;
    public NotificationList(int number) => _number = number;
    public int GetNumber() => _number;
}