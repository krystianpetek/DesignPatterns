# Adapter pattern

## Requirement description

Zewnętrzne API, odpowiedzialne za zarządzanie użytkownikami naszej aplikacji udostępnia nam bibliotekę do komunikacji z nimi. Biblioteka zawiera jedną metoda, zwracającą listę użytkowników w formacie XML (imię, nazwisko).

Część systemu tworzona przez nas, na potrzeby jednego z modułów wymaga listy nazw użytkowników (wynik konkatenacji imię + nazwisko). W innym module aplikacji potrzebne jest wczytywanie użytkowników z dokumentu CSV, dostarczonego przez dział księgowy.

Proszę napisać adapter który dokona konwersji listy użytkowników z formatu CSV na interfejs znany naszej aplikacji, a następnie wyświetlić w terminalu wszystkich klientów.

Wynik działania aplikacji:

1. Adam Nowak
2. Katarzyna Kowalska
3. Wojciech Jankowski

## Example for to be completed

```csharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml;

namespace Adapter;

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

// tu trzeba dopisać własny adapter implementujący odpowiedni interfejs

public class Program
{
    static void Main(string[] args)
    {
        UsersApi userRepository = new UsersApi();

        IUserRepository adapter = new UsersRepositoryAdapter(userRepository);

        List<string> users = adapter.GetUserNames();
        foreach (var userName in users)
        {
            Console.WriteLine(userName);
        }

        // var values = "name,surname".Split(",");

        // foreach(var val in values)
        // {
        //   Console.WriteLine(val);
        // }

        // TODO: wyświetl w konsoli
    }
}
```
