using System;
using Strategy.Contracts;

namespace Strategy.Characters.Jumps;

class LongJump : IJumpType
{
    public void Jump() => Console.WriteLine("Long jump");
}
