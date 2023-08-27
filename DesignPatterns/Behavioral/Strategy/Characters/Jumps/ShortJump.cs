using System;
using Strategy.Contracts;

namespace Strategy.Characters.Jumps;

class ShortJump : IJumpType
{
    public void Jump() => Console.WriteLine("Short jump");
}
