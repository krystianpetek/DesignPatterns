namespace ChainOfResponsibility.Contracts;

interface IWarningHandler
{
    IWarningHandler SetNext(IWarningHandler nextHandler);
    void Handle(int daysOfPaymentDelay);
}
