using System.IO;

namespace Adapter.Adapters.Csv;

public class CsvService
{
    private readonly string _readContent;

    public CsvService()
    {
        Stream fileStream = new FileStream(".\\Requirements\\users.csv", FileMode.OpenOrCreate);
        StreamReader streamReader = new StreamReader(fileStream);
        _readContent = streamReader.ReadToEnd();
        streamReader.Close();
    }

    public string GetUsersFromCsv => _readContent;
}
