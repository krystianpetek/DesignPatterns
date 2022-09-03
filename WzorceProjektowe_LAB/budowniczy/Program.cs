using System;
using System.Text;

namespace budowniczy
{
    public class Computer
    {
        private string _type;
        public double Price { get; set; }
        public string MotherBoard { get; set; }
        public string Screen { get; set; }
        public string HardDrive { get; set; }
        public string Processor { get; set; }

        public Computer(string computerType)
        {
            _type = computerType;
            Price = 0;
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("Typ: " + _type);
            Console.WriteLine("Płyta główna: " + MotherBoard);
            Console.WriteLine("Procesor: " + Processor);
            Console.WriteLine("Dysk: " + HardDrive);
            Console.WriteLine("Monitor: " + Screen);
            Console.WriteLine("Cena: " + $"{Price:F2} zł");
        }
    }


    public class ComputerShop
    {

        public void ConstructComputer(ComputerBuilder computerBuilder)
        {
            computerBuilder.BuildScreen();
            computerBuilder.BuildMotherboard();
            computerBuilder.BuildProcessor();
            computerBuilder.BuildHardDrive();
        }

    }



    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }
        public abstract void BuildScreen();
        public abstract void BuildMotherboard();
        public abstract void BuildProcessor();
        public abstract void BuildHardDrive();
    }


    public class OfficeComputerBuilder : ComputerBuilder
    {

        public OfficeComputerBuilder()
        {
            Computer = new Computer("biurowy");
        }

        public override void BuildScreen()
        {
            Computer.Screen = "BenQ GW2270H (1920x1080)";
            Computer.Price += 369.00;
        }
        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Asus Prime A320M-E";
            Computer.Price += 259.90;
        }
        public override void BuildProcessor()
        {
            Computer.Processor = "AMD Ryzen 5 2600";
            Computer.Price += 589.00;
        }
        public override void BuildHardDrive()
        {
            Computer.HardDrive = "Goodram CX400 250 GB SATA3";
            Computer.Price += 149.99;
        }
    }

    public class GamingComputerBuilder : ComputerBuilder
    {

        public GamingComputerBuilder()
        {
            Computer = new Computer("gamingowy");
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

    public class ProfessionalComputerBuilder : ComputerBuilder
    {
        public ProfessionalComputerBuilder()
        {
            Computer = new Computer("profesjonalny");
        }
        public override void BuildScreen()
        {
            Computer.Screen = "Eizo CG319X (4096x2160)";
            Computer.Price += 20749.00;
        }
        public override void BuildMotherboard()
        {
            Computer.MotherBoard = "Supermicro MBD X11DPH";
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

    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ComputerShop computerShop = new ComputerShop();

            ComputerBuilder computerBuilder = new OfficeComputerBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();
            Console.WriteLine();
            computerBuilder = new GamingComputerBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();
            Console.WriteLine();
            computerBuilder = new ProfessionalComputerBuilder();
            computerShop.ConstructComputer(computerBuilder);
            computerBuilder.Computer.DisplayConfiguration();


        }
    }
}
