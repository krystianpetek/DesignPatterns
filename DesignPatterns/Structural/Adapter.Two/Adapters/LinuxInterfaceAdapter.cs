using System;
using Adapter.Two.Contracts;

namespace Adapter.Two.Adapters;

public class LinuxInterfaceAdapter : IWindows, ILinux
{
    public void PowerShell()
    {
        Terminal();
    }

    public void MicrosoftEdge()
    {
        MozillaFirefox();
    }

    public void MozillaFirefox()
    {
        Console.WriteLine("Ubuntu: Mozilla Firefox");
    }

    public void Terminal()
    {
        Console.WriteLine("Ubuntu: Terminal");
    }
}
