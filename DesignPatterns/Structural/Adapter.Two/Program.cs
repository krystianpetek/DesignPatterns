using System;
using Adapter.Two.Adapters;
using Adapter.Two.Contracts;

namespace SAdapter;

internal partial class Program
{
    static void Main(string[] args)
    {
        IWindows win = new Windows10();
        ILinux linux = new Ubuntu();
        win.PowerShell();
        win.MicrosoftEdge();

        Console.WriteLine("\nWindows -> Linux adapter (inheritance)");
        LinuxInheritanceAdapter inheritanceAdapter = new LinuxInheritanceAdapter(linux);
        inheritanceAdapter.PowerShell();
        inheritanceAdapter.MicrosoftEdge();

        Console.WriteLine("\nWindows -> Linux adapter (interface)");
        LinuxInterfaceAdapter interfaceAdapter = new LinuxInterfaceAdapter();
        interfaceAdapter.PowerShell();
        interfaceAdapter.MicrosoftEdge();
    }
}
