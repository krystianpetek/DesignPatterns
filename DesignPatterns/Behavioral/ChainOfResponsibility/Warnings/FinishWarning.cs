using System;
using ChainOfResponsibility.Contracts;

namespace ChainOfResponsibility.Warnings;

class FinishWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay > 10)
            Console.WriteLine($"Lock Account, {daysOfPaymentDelay} days delayed.");
        else
            base.Handle(daysOfPaymentDelay);
    }
}
