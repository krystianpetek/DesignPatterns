﻿using Proxy.Files;
using Proxy.Two.Contracts;
using Proxy.Two.Entities;

namespace Proxy.Two;

public static class Program
{
    public static void Main()
    {
        IAccess dostep = new FileProxy();

        User user = new User(Role.User);
        dostep.GetAccess(user);

        user = new User(Role.Admin);
        dostep.GetAccess(user);
    }
}