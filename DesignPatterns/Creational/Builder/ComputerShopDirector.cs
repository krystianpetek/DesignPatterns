using Builder.Contracts;

namespace Builder;

public class ComputerShopDirector
{
    public void ConstructComputer(ComputerBuilder computerBuilder)
    {
        computerBuilder.BuildScreen();
        computerBuilder.BuildMotherboard();
        computerBuilder.BuildProcessor();
        computerBuilder.BuildHardDrive();
    }
}
