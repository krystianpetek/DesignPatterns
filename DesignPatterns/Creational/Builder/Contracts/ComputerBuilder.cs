using Builder.Entities;

namespace Builder.Contracts;

public abstract class ComputerBuilder
{
    protected Computer Computer { get; set; }
    public abstract void BuildScreen();
    public abstract void BuildMotherboard();
    public abstract void BuildProcessor();
    public abstract void BuildHardDrive();
    public void GetComputerDetails() => Computer.DisplayConfiguration();
}
