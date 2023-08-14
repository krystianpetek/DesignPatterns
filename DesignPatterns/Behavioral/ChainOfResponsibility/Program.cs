using ChainOfResponsibility.Contracts;
using ChainOfResponsibility.Warnings;

namespace ChainOfResponsibility;

public static class Program
{
    public static void Main()
    {
        IWarningHandler lightWarningHandler = new LightWarning();
        IWarningHandler mediumWarningHandler = new MediumWarning();
        IWarningHandler hardWarningHandler = new HardWarning();
        IWarningHandler finishWarningHandler = new FinishWarning();

        lightWarningHandler.SetNext(mediumWarningHandler);
        mediumWarningHandler.SetNext(hardWarningHandler);
        hardWarningHandler.SetNext(finishWarningHandler);

        lightWarningHandler.Handle(0);
        lightWarningHandler.Handle(1);
        lightWarningHandler.Handle(4);
        lightWarningHandler.Handle(9);
        lightWarningHandler.Handle(11);
    }
}
