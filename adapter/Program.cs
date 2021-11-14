using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace WzorzecAdapter
{
    //KOD Z ZEWNĘTRZNEJ BIBLIOTEKI
    public class UsersApi
    {
        public async Task<string> GetUsersXmlAsync()
        {
            var apiResponse = "<?xml version= \"1.0\" encoding= \"UTF-8\"?><users><user name=\"John\" surname=\"Doe\"/><user name=\"John\" surname=\"Wayne\"/><user name=\"John\" surname=\"Rambo\"/></users>";

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(apiResponse);

            return await Task.FromResult(doc.InnerXml);
        }
    }

    // tu trzeba dopisać klasę zwracającą zawartość pliku csv w postaci stringa (jednego długiego, rozdzielanego znakami nowego wiersza)
    public class CsvApi
    {
        FileStream fs { get; set; }
        StreamReader sr { get; set; }
        private string wczytanyPlik;
        public CsvApi()
        {
            fs = new FileStream("users.csv", FileMode.OpenOrCreate);
            sr = new StreamReader(fs);
            wczytanyPlik = sr.ReadToEnd();
            sr.Close();
        }
        public string Odczyt() => wczytanyPlik;
    }

    public interface IUserRepository
    {
        List<string> GetUserNames();
    }

    public class UsersRepositoryAdapter : IUserRepository
    {
        private UsersApi _adaptee = null;

        public UsersRepositoryAdapter(UsersApi adaptee)
        {
            _adaptee = adaptee;
        }

        public List<string> GetUserNames()
        {
            string incompatibleApiResponse = this._adaptee
              .GetUsersXmlAsync()
              .GetAwaiter()
              .GetResult();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(incompatibleApiResponse);

            var rootEl = doc.LastChild;

            List<string> userNames = new List<string>();

            if (rootEl.HasChildNodes)
            {
                foreach (XmlNode user in rootEl.ChildNodes)
                {
                    userNames.Add(user.Attributes["name"].InnerText + user.Attributes["surname"].InnerText);
                }
            }
            return userNames;
        }

    }

    public class CsvRepositoryAdapter : IUserRepository
    {
        private CsvApi _adapter = null;
        public CsvRepositoryAdapter(CsvApi adapter)
        {
            _adapter = adapter;
        }
        public List<string> GetUserNames()
        {
            List<string> userNames = new List<string>();
            string plik = _adapter.Odczyt();
            var linia = plik.Split("\n");
            foreach (var podzial in linia)
            {
                var imieNazwisko = podzial.Split(",");
                userNames.Add(imieNazwisko[0] + " " + imieNazwisko[1]);                
            }
               
            return userNames;
        }
    }
    // tu trzeba dopisać własny adapter implementujący odpowiedni interfejs

    public class Program
    {

        static void Main(string[] args)
        {

            //UsersApi userRepository = new UsersApi();

            //IUserRepository adapter = new UsersRepositoryAdapter(userRepository);

            //List<string> users = adapter.GetUserNames();
            //foreach (var userName in users)
            //{
            //    Console.WriteLine(userName);
            //}

            //var values = "name,surname".Split(",");

            // foreach(var val in values)
            // {
            //   Console.WriteLine(val);
            // }

            // TODO: wyświetl w konsoli

            List<string> users2 = new List<string>();
            CsvApi csvApi = new CsvApi();
            IUserRepository adapter2 = new CsvRepositoryAdapter(csvApi);
            users2 = adapter2.GetUserNames();
            int licznik = 0;
            foreach (var userName in users2)
            {
                Console.WriteLine($"{++licznik}. "+ userName);
            }


        }

    }


}





//using System;
//using System.Collections.Generic;
//using System.Threading.Tasks;
//using System.Xml;

//namespace WzorzecAdapter
//{
//    //KOD Z ZEWNĘTRZNEJ BIBLIOTEKI
//    public class UsersApi
//    {
//        public async Task<string> GetUsersXmlAsync()
//        {
//            var apiResponse = "<?xml version= \"1.0\" encoding= \"UTF-8\"?><users><user name=\"John\" surname=\"Doe\"/><user name=\"John\" surname=\"Wayne\"/><user name=\"John\" surname=\"Rambo\"/></users>";

//            XmlDocument doc = new XmlDocument();
//            doc.LoadXml(apiResponse);

//            return await Task.FromResult(doc.InnerXml);
//        }
//    }

//    // tu trzeba dopisać klasę zwracającą zawartość pliku csv w postaci stringa (jednego długiego, rozdzielanego znakami nowego wiersza)


//    public interface IUserRepository
//    {
//        List<string> GetUserNames();
//    }

//    public class UsersRepositoryAdapter : IUserRepository
//    {
//        private UsersApi _adaptee = null;

//        public UsersRepositoryAdapter(UsersApi adaptee)
//        {
//            _adaptee = adaptee;
//        }

//        public List<string> GetUserNames()
//        {
//            string incompatibleApiResponse = this._adaptee
//              .GetUsersXmlAsync()
//              .GetAwaiter()
//              .GetResult();

//            XmlDocument doc = new XmlDocument();
//            doc.LoadXml(incompatibleApiResponse);

//            var rootEl = doc.LastChild;

//            List<string> userNames = new List<string>();

//            if (rootEl.HasChildNodes)
//            {
//                foreach (XmlNode user in rootEl.ChildNodes)
//                {
//                    userNames.Add(user.Attributes["name"].InnerText + user.Attributes["surname"].InnerText);
//                }
//            }
//            return userNames;
//        }

//    }

//    // tu trzeba dopisać własny adapter implementujący odpowiedni interfejs

//    public class Program
//    {

//        static void Main(string[] args)
//        {

//            UsersApi userRepository = new UsersApi();

//            IUserRepository adapter = new UsersRepositoryAdapter(userRepository);

//            List<string> users = adapter.GetUserNames();
//            foreach (var userName in users)
//            {
//                Console.WriteLine(userName);
//            }

//            // var values = "name,surname".Split(",");

//            // foreach(var val in values)
//            // {
//            //   Console.WriteLine(val);
//            // }

//            // TODO: wyświetl w konsoli
//        }

//    }


//}