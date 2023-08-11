using System;
using Proxy.Contracts;

namespace Proxy.Clients;

public class RealClient : IClient
{
    private readonly string _data;

    public RealClient()
    {
        Console.WriteLine("RealClient: Initialized");
        _data = "WSEI data";
    }
    public string GetData()
    {
        return _data;
    }
}
