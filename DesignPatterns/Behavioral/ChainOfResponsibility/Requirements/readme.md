# Chain of responsibility pattern

## Requirement description

Proszę stworzyć kolejne obiekty umożliwiające obsługę żądania.

W przypadku opóźnienia powyżej 5 dni i do 10 dni, zasymuluj wysłanie SMS z ponagleniem.
W przypadku opóźnienia powyżej 10 dni zasymuluj zablokowanie konta.

## Example for to be completed

```csharp
using System;

namespace lancuchZobowiazan
{
    using System;

    interface IWarningHandler
    {
        IWarningHandler SetNext(IWarningHandler nextHandler);
        void Handle(int daysOfPaymentDelay);
    }

    abstract class WarningHandler : IWarningHandler
    {
        protected IWarningHandler _nextHandler;

        public virtual void Handle(int daysOfPaymentDelay)
        {
            if (_nextHandler != null)
            {
                _nextHandler.Handle(daysOfPaymentDelay);
            }
            else
            {
                Console.WriteLine("What now?");
            }
        }

        public IWarningHandler SetNext(IWarningHandler nextHandler)
        {
            _nextHandler = nextHandler;

            return nextHandler;
        }
    }

    class LightWarning : WarningHandler
    {
        public override void Handle(int daysOfPaymentDelay)
        {
            if (daysOfPaymentDelay == 1)
            {
                Console.WriteLine("Send push notification");
            }
            else
            {
                base.Handle(daysOfPaymentDelay);
            }
        }
    }

    class MediumWarning : WarningHandler
    {
        public override void Handle(int daysOfPaymentDelay)
        {
            if (daysOfPaymentDelay > 1 && daysOfPaymentDelay <= 5)
            {
                Console.WriteLine("Send email notification");
            }
            else
            {
                base.Handle(daysOfPaymentDelay);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IWarningHandler lightWarningHandler = new LightWarning();
            IWarningHandler mediumWarningHandler = new MediumWarning();

            lightWarningHandler.SetNext(mediumWarningHandler);

            lightWarningHandler.Handle(2);
        }
    }
}
```
