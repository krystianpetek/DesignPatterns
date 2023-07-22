using System;

namespace KMetodaWytworcza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFabrykaSamochodow fabryka = new FabrykaOsobowych();
            ISamochod samochod = fabryka.StworzSamochod();
            Console.WriteLine(samochod);
            fabryka = new FabrykaCiezarowych();
            samochod = fabryka.StworzSamochod();
            Console.WriteLine(samochod);
        }
    }
    public interface ISamochod { }
    public interface IFabrykaSamochodow
    {
        public ISamochod StworzSamochod();
    }
    public class Osobowy : ISamochod { }
    public class Terenowy: ISamochod { }
    public class Ciezarowy : ISamochod { }
    public class FabrykaOsobowych : IFabrykaSamochodow
    {
        public ISamochod StworzSamochod()
        {
            return new Osobowy();    
        }
    }
    public class FabrykaTerenowych : IFabrykaSamochodow
    {
        public ISamochod StworzSamochod()
        {
            return new Terenowy();
        }
    }
    public class FabrykaCiezarowych : IFabrykaSamochodow
    {
        public ISamochod StworzSamochod()
        {
            return new Ciezarowy();
        }
    }


}
