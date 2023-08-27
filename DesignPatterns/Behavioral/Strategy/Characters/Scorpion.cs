using System;
using Strategy.Contracts;

namespace Strategy.Characters;

internal class Scorpion : CharacterBase
{
    public Scorpion(IKickType kickType, IJumpType jumpType) : base(kickType, jumpType) { }

    override public void IntroduceCharacter() => Console.WriteLine("I'm Scorpion!");
}
