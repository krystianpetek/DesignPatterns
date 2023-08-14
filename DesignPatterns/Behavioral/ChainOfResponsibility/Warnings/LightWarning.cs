using System;
using ChainOfResponsibility.Contracts;

namespace ChainOfResponsibility.Warnings;

class LightWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay == 1)
            Console.WriteLine($"Send push notification, {daysOfPaymentDelay} days delayed.");
        else
            base.Handle(daysOfPaymentDelay);

    }
}
