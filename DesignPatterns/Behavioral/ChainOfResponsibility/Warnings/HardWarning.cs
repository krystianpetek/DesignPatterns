using System;
using ChainOfResponsibility.Contracts;

namespace ChainOfResponsibility.Warnings;

class HardWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay > 5 && daysOfPaymentDelay <= 10)
            Console.WriteLine($"Send SMS notification, {daysOfPaymentDelay} days delayed.");
        else
            base.Handle(daysOfPaymentDelay);
    }
}
