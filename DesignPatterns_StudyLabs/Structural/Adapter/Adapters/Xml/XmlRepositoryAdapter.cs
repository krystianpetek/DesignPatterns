using System.Collections.Generic;
using System.Xml;
using Adapter.Contracts;

namespace Adapter.Adapters.Xml;

public class XmlRepositoryAdapter : IRepositoryAdapter
{
    private readonly XmlService _xmlService;

    public XmlRepositoryAdapter(XmlService xmlService)
    {
        _xmlService = xmlService;
    }

    public List<string> GetUserNames()
    {
        string incompatibleApiResponse = _xmlService.GetUsersFromXml;

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(incompatibleApiResponse);
        XmlNode xmlRootElement = xmlDocument.LastChild;

        List<string> userNames = new List<string>();
        if (xmlRootElement.HasChildNodes)
        {
            foreach (XmlNode user in xmlRootElement.ChildNodes)
            {
                userNames.Add($"{user.Attributes["name"].InnerText} {user.Attributes["surname"].InnerText}");
            }
        }
        return userNames;
    }
}
