using System;
using Adapter.Two.Contracts;

namespace SAdapter;

internal partial class Program
{
    public class Windows10 : IWindows
    {
        public void PowerShell()
        {
            Console.WriteLine("Windows 10: PowerShell");
        }

        public void MicrosoftEdge()
        {
            Console.WriteLine("Windows 10: Microsoft Edge");
        }
    }
}
