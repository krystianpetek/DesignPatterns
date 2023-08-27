using System;
using Strategy.Contracts;

namespace Strategy.Characters.Kicks;

class FlameKick : IKickType
{
    public void Kick() => Console.WriteLine("Flame kick");
}
