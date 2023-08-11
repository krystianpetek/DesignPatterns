using System;
using Proxy.Two.Contracts;
using Proxy.Two.Entities;

namespace Proxy.Two.Files;

public class FileProxy : IAccess
{
    private readonly IAccess _file;
    public FileProxy()
    {
        _file = new File();
    }

    public void GetAccess(User user)
    {
        if (user.UserRole == Role.Admin)
            _file.GetAccess(user);
        else
            Console.WriteLine("You are not admin.");
    }
}
