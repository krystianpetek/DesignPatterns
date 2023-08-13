using Builder.Contracts;
using Builder.Entities;

namespace Builder.Builders;

public class GamingComputerBuilder : ComputerBuilder
{

    public GamingComputerBuilder()
    {
        Computer = new Computer("gaming");
    }

    public override void BuildScreen()
    {
        Computer.Screen = "HP Z4W65A4 (3840x1600)";
        Computer.Price += 4927.75;
    }
    public override void BuildMotherboard()
    {
        Computer.MotherBoard = "Gigabyte X570 Aorus Elite";
        Computer.Price += 895.60;
    }
    public override void BuildProcessor()
    {
        Computer.Processor = "Intel i7 9700K";
        Computer.Price += 1829.00;
    }
    public override void BuildHardDrive()
    {
        Computer.HardDrive = "Samsung 970 EVO Plus 2TB M.2";
        Computer.Price += 2028.45;
    }
}
