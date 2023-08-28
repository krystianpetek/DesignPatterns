using System.Collections.Generic;
using Visitor.Contracts;

namespace Visitor.Extensions;

public static class ClientExtension
{
    public static void ClientCode(this List<ICity> components, IVisitor visitor)
    {
        foreach (ICity component in components)
        {
            component.Accept(visitor);
        }
    }
}
