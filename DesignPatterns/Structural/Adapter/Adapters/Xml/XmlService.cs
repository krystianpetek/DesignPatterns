using System.IO;
using System.Xml;

namespace Adapter.Adapters.Xml;

public class XmlService
{
    private readonly XmlDocument _xmlDocument;

    public XmlService()
    {
        Stream fileStream = new FileStream(".\\Requirements\\users.xml", FileMode.OpenOrCreate);
        StreamReader streamReader = new StreamReader(fileStream);
        string readContent = streamReader.ReadToEnd();
        streamReader.Close();

        _xmlDocument = new XmlDocument();
        _xmlDocument.LoadXml(readContent);
    }

    public string GetUsersFromXml => _xmlDocument.InnerXml;
}
