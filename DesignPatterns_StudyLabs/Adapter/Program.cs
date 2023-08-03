using System;
using System.Collections.Generic;
using Adapter.Adapters.Csv;
using Adapter.Adapters.Xml;
using Adapter.Contracts;

namespace Adapter;

public static class Program
{
    public static void Main()
    {
        int counter;
        List<string> users;
        IRepositoryAdapter repositoryAdapter;

        #region XmlAdapter
        counter = 0;
        repositoryAdapter = new XmlRepositoryAdapter(new XmlService());
        users = repositoryAdapter.GetUserNames();

        Console.WriteLine("XML");
        foreach (var userName in users)
        {
            Console.WriteLine($"{++counter}. {userName}");
        }
        #endregion

        #region CsvAdapter
        counter = 0;
        repositoryAdapter = new CsvRepositoryAdapter(new CsvService());
        users = repositoryAdapter.GetUserNames();

        Console.WriteLine("CSV");
        foreach (var userName in users)
        {
            Console.WriteLine($"{++counter}. {userName}");
        }
        #endregion
    }
}