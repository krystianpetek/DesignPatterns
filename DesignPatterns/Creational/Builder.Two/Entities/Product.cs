using System.Collections.Generic;
using System.Text;

namespace Builder.Two.Entities;

public class Product
{
    private readonly List<object> _parts = new List<object>();

    public void Add(string part) => _parts.Add(part);
    public string ListParts()
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < _parts.Count; i++)
        {
            if (i == _parts.Count - 1)
                stringBuilder.Append($"{_parts[i]}");
            else
                stringBuilder.Append($"{_parts[i]}, ");
        }
        return "Product parts: " + stringBuilder + "\n";
    }
}
