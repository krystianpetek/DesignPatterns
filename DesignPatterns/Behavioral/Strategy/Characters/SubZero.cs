using System;
using Strategy.Contracts;

namespace Strategy.Characters;

class SubZero : CharacterBase
{
    public SubZero(IKickType kickType, IJumpType jumpType) : base(kickType, jumpType) { }

    override public void IntroduceCharacter() => Console.WriteLine("I'm Sub-Zero!");
}
