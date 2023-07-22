using System;

namespace SAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Windows10 win = new Windows10();
            Ubuntu linux = new Ubuntu();
            AdapterLinuxObiektowo adapterObiektowy = new AdapterLinuxObiektowo(linux);
            win.CMD();
            win.MicrosoftEdge();
            Console.WriteLine("\nadapter obiektowy");
            adapterObiektowy.CMD();
            adapterObiektowy.MicrosoftEdge();

            Console.WriteLine();
            AdapterLinuxKlasowo adapterKlasowy = new AdapterLinuxKlasowo();
            Console.WriteLine("adapter klasowy");
            adapterKlasowy.CMD();
            adapterKlasowy.MicrosoftEdge();
        }
        interface Windows
        {
            void MicrosoftEdge();
            void CMD();
        }
        interface Linux
        {
            void Przegladarka();
            void Terminal();
        }
        public class Windows10 : Windows
        {
            public void CMD()
            {
                Console.WriteLine("Windows 10: CMD");
            }

            public void MicrosoftEdge()
            {
                Console.WriteLine("Windows 10: Microsoft Edge");
            }
        }
        public class Ubuntu : Linux
        {
            public void Terminal()
            {
                Console.WriteLine("Ubuntu: TERMINAL");
            }
            public void Przegladarka()
            {
                Console.WriteLine("Ubuntu: Mozilla Firefox");
            }
        }
        public class AdapterLinuxObiektowo: Windows
        {
            public AdapterLinuxObiektowo(Ubuntu linux)
            {
                this.Ubuntu = linux;
            }
            private Ubuntu Ubuntu;
            public void CMD()
            {
                Ubuntu.Terminal();
            }

            public void MicrosoftEdge()
            {
                Ubuntu.Przegladarka();
            }
        }

        public class AdapterLinuxKlasowo : Windows, Linux
        {
            public void CMD()
            {
                Terminal();
            }

            public void MicrosoftEdge()
            {
                Przegladarka();
            }

            public void Przegladarka()
            {
                Console.WriteLine("Ubuntu: Mozilla Firefox");
            }

            public void Terminal()
            {
                Console.WriteLine("Ubuntu: Terminal");
            }
        }
    }
}
