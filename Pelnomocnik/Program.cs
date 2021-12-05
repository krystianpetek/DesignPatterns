using System;
public interface IClient
{
    string GetData();
}

public class RealClient : IClient
{
    string Data;
    public RealClient()
    {
        Console.WriteLine("RealClient: Initialized");
        Data = "WSEI data";
    }
    public string GetData()
    {
        return Data;
    }
}

public class ProxyClient : IClient
{
    RealClient client = null;
    bool _authenticated = false;
    string data = null;
    private string _pass = "dobrehaslo";
    public ProxyClient(string password)
    {
        if (password == _pass)
        {
            _authenticated = true;
            Console.WriteLine("ProxyClient: Initialized");
            client = new RealClient();
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
        {
            data = $"Data from Proxy Client = {client.GetData()}";
        }
        return data;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProxyClient proxy1 = new ProxyClient("zlehaslo");
        Console.WriteLine(proxy1.GetData());
        ProxyClient proxy2 = new ProxyClient("dobrehaslo");
        Console.WriteLine(proxy2.GetData());
    }
}



//using System;

//    public interface IClient
//{
//    string GetData();
//}

//public class RealClient : IClient
//{
//    //
//    //

//    public RealClient()
//    {
//        Console.WriteLine("RealClient: Initialized");
//        Data = "WSEI data";
//    }

//    public string GetData()
//    {
//        //
//        //
//    }
//}


//public class ProxyClient : IClient
//{
//    RealClient client = null;
//    //
//    //
//    private _pass ="jakies haslo";
//        public ProxyClient(string password)
//    {
//        if (password == _pass)
//        {
//            //
//            //
//        }
//        else
//        {
//            _authenticated = false; // dla pewności :)
//                                    //
//                                    //
//        }
//    }

//    public string GetData()
//    {
//        if (_authenticated)
//        {
//            //
//            //
//        }
//        //
//        //
//    }
//}


//class Program
//{
//    static void Main(string[] args)
//    {

//        ProxyClient proxy1 = new ProxyClient("zlehaslo");
//        //
//        //

//        ProxyClient proxy2 = new ProxyClient("dobrehaslo");
//        //
//        //

//    }

//}
