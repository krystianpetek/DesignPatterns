using System;
using Proxy.Clients;
using Proxy.Contracts;

namespace Proxy;

public static class Program
{
    public static void Main()
    {
        IClient proxy1 = new ProxyClient("wrongpassword");
        string data = proxy1.GetData();
        Console.WriteLine($"ProxyClient with wrong password {data}\n");

        IClient proxy2 = new ProxyClient("goodpassword");
        data = proxy2.GetData();
        Console.WriteLine($"ProxyClient with correct password {data}\n");
    }
}