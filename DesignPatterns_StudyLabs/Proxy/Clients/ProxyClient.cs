using System;
using Proxy.Contracts;

namespace Proxy.Clients;

public class ProxyClient : IClient
{
    private readonly RealClient _client;
    private readonly bool _authenticated;
    private readonly string _pass = "goodpassword";
    private string _data;

    public ProxyClient(string password)
    {
        if (password == _pass)
        {
            _authenticated = true;
            Console.WriteLine("ProxyClient: Initialized");
            _client = new RealClient();
        }
        else
        {
            _authenticated = false; // dla pewności :)
            Console.WriteLine("ProxyClient: Access denied");
        }
    }

    public string GetData()
    {
        if (_authenticated)
            _data = $"Data from Proxy Client = {_client.GetData()}";
        return _data;
    }
}
