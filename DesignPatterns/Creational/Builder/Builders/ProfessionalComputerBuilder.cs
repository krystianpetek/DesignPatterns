using Builder.Contracts;
using Builder.Entities;

namespace Builder.Builders;

public class ProfessionalComputerBuilder : ComputerBuilder
{
    public ProfessionalComputerBuilder()
    {
        Computer = new Computer("professional");
    }

    public override void BuildScreen()
    {
        Computer.Screen = "Eizo CG319X (4096x2160)";
        Computer.Price += 20749.00;
    }

    public override void BuildMotherboard()
    {
        Computer.Motherboard = "Supermicro MBD X11DPH";
        Computer.Price += 2755.30;
    }

    public override void BuildProcessor()
    {
        Computer.Processor = "Intel Xeon Gold 5120";
        Computer.Price += 7999.00;
    }

    public override void BuildHardDrive()
    {
        Computer.HardDrive = "Seagate Skyhawk 14TB 3.5\"";
        Computer.Price += 2101.75;
    }
}
