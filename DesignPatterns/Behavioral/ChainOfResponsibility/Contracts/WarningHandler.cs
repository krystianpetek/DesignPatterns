using System;

namespace ChainOfResponsibility.Contracts;

abstract class WarningHandler : IWarningHandler
{
    protected IWarningHandler _nextHandler;

    public virtual void Handle(int daysOfPaymentDelay)
    {
        if (_nextHandler != null)
            _nextHandler?.Handle(daysOfPaymentDelay);
        else
            Console.WriteLine($"{daysOfPaymentDelay} days delayed, What now?");
    }

    public IWarningHandler SetNext(IWarningHandler nextHandler)
    {
        _nextHandler = nextHandler;
        return nextHandler;
    }
}
