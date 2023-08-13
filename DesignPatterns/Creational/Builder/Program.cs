using System;
using Builder.Builders;
using Builder.Contracts;

namespace Builder;

public static class Program
{

    public static void Main()
    {
        ComputerShopDirector computerShop = new ComputerShopDirector();
        
        ComputerBuilder computerBuilder = new OfficeComputerBuilder();
        computerShop.ConstructComputer(computerBuilder);
        computerBuilder.GetComputerDetails();
        Console.WriteLine();

        computerBuilder = new GamingComputerBuilder();
        computerShop.ConstructComputer(computerBuilder);
        computerBuilder.GetComputerDetails();
        Console.WriteLine();

        computerBuilder = new ProfessionalComputerBuilder();
        computerShop.ConstructComputer(computerBuilder);
        computerBuilder.GetComputerDetails();
    }
}
