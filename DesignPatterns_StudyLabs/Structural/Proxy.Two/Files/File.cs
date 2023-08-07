using System;
using Proxy.Two.Contracts;
using Proxy.Two.Entities;

namespace Proxy.Two.Files;

public class File : IAccess
{
    public void GetAccess(User user)
    {
        Console.WriteLine(user);
    }
}
