using System;

public interface IClient
{
    string GetData();
}

public class RealClient : IClient
{
    //
    //

    public RealClient()
    {
        Console.WriteLine("RealClient: Initialized");
        Data = "WSEI data";
    }

    public string GetData()
    {
        //
        //
    }
}


public class ProxyClient : IClient
{
    RealClient client = null;
    //
    //
    private _pass ="jakies haslo";
        public ProxyClient(string password)
    {
        if (password == _pass)
        {
            //
            //
        }
        else
        {
            _authenticated = false; // dla pewności :)
                                    //
                                    //
        }
    }

    public string GetData()
    {
        if (_authenticated)
        {
            //
            //
        }
        //
        //
    }
}


class Program
{
    static void Main(string[] args)
    {

        ProxyClient proxy1 = new ProxyClient("zlehaslo");
        //
        //

        ProxyClient proxy2 = new ProxyClient("dobrehaslo");
        //
        //

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
