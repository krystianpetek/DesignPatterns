using System;

namespace ChainOfResponsibility;

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
            _nextHandler.Handle(daysOfPaymentDelay);
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
            Console.WriteLine("Send push notification");
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
            Console.WriteLine("Send email notification");
        else
        {
            base.Handle(daysOfPaymentDelay);
        }
    }
}

class HardWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay > 5 && daysOfPaymentDelay <= 10)
            Console.WriteLine("Send SMS notification");
        else
        {
            base.Handle(daysOfPaymentDelay);
        }
    }
}

class FinishWarning : WarningHandler
{
    public override void Handle(int daysOfPaymentDelay)
    {
        if (daysOfPaymentDelay > 10)
            Console.WriteLine("Lock Account");
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
        IWarningHandler hardWarningHandler = new HardWarning();
        IWarningHandler finishWarningHandler = new FinishWarning();

        lightWarningHandler.SetNext(mediumWarningHandler);
        mediumWarningHandler.SetNext(hardWarningHandler);
        hardWarningHandler.SetNext(finishWarningHandler);

        lightWarningHandler.Handle(11);
    }
}








//using System;

//namespace lancuchZobowiazan
//{
//    using System;

//    interface IWarningHandler
//    {
//        IWarningHandler SetNext(IWarningHandler nextHandler);
//        void Handle(int daysOfPaymentDelay);
//    }

//    abstract class WarningHandler : IWarningHandler
//    {
//        protected IWarningHandler _nextHandler;

//        public virtual void Handle(int daysOfPaymentDelay)
//        {
//            if (_nextHandler != null)
//            {
//                _nextHandler.Handle(daysOfPaymentDelay);
//            }
//            else
//            {
//                Console.WriteLine("What now?");
//            }
//        }

//        public IWarningHandler SetNext(IWarningHandler nextHandler)
//        {
//            _nextHandler = nextHandler;

//            return nextHandler;
//        }
//    }

//    class LightWarning : WarningHandler
//    {
//        public override void Handle(int daysOfPaymentDelay)
//        {
//            if (daysOfPaymentDelay == 1)
//            {
//                Console.WriteLine("Send push notification");
//            }
//            else
//            {
//                base.Handle(daysOfPaymentDelay);
//            }
//        }
//    }
//    class MediumWarning : WarningHandler
//    {
//        public override void Handle(int daysOfPaymentDelay)
//        {
//            if (daysOfPaymentDelay > 1 && daysOfPaymentDelay <= 5)
//            {
//                Console.WriteLine("Send email notification");
//            }
//            else
//            {
//                base.Handle(daysOfPaymentDelay);
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IWarningHandler lightWarningHandler = new LightWarning();
//            IWarningHandler mediumWarningHandler = new MediumWarning();

//            lightWarningHandler.SetNext(mediumWarningHandler);

//            lightWarningHandler.Handle(2);
//        }
//    }


//}
