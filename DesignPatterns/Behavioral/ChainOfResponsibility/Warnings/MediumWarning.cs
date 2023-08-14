using System;
using ChainOfResponsibility.Contracts;

namespace ChainOfResponsibility.Warnings;

class MediumWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay > 1 && daysOfPaymentDelay <= 5)
            Console.WriteLine($"Send email notification, {daysOfPaymentDelay} days delayed.");
        else
            base.Handle(daysOfPaymentDelay);
    }
}
