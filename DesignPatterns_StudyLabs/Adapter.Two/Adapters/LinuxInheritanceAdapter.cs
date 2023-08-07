using Adapter.Two.Contracts;

namespace Adapter.Two.Adapters;

public class LinuxInheritanceAdapter : IWindows
{
    private readonly ILinux _ubuntu;

    public LinuxInheritanceAdapter(ILinux linux)
    {
        _ubuntu = linux;
    }

    public void PowerShell()
    {
        _ubuntu.Terminal();
    }

    public void MicrosoftEdge()
    {
        _ubuntu.MozillaFirefox();
    }
}
