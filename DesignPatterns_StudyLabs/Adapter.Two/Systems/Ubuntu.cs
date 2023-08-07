using System;
using Adapter.Two.Contracts;

namespace SAdapter;

internal partial class Program
{
    public class Ubuntu : ILinux
    {
        public void Terminal()
        {
            Console.WriteLine("Ubuntu: Terminal");
        }
        public void MozillaFirefox()
        {
            Console.WriteLine("Ubuntu: Mozilla Firefox");
        }
    }
}
