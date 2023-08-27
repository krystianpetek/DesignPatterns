using System;
using Strategy.Contracts;

namespace Strategy.Characters.Kicks;

class IceKick : IKickType
{
    public void Kick() => Console.WriteLine("Ice kick");
}
