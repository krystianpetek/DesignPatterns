using System;
using Strategy.Characters;
using Strategy.Characters.Jumps;
using Strategy.Characters.Kicks;
using Strategy.Contracts;

namespace Strategy;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("-- Mortal Kombat --");

        IJumpType shortJump = new ShortJump();
        IJumpType longJump = new LongJump();

        IKickType iceKick = new IceKick();
        IKickType flameKick = new FlameKick();

        CharacterBase subZero = new SubZero(iceKick, shortJump);
        subZero.IntroduceCharacter();
        subZero.Hit();
        subZero.Kick();
        subZero.Jump();
        subZero.SetJumpType(longJump);
        subZero.Jump();

        CharacterBase scorpion = new Scorpion(flameKick, longJump);
        scorpion.IntroduceCharacter();
        scorpion.Hit();
        scorpion.Kick();
        scorpion.SetKickType(iceKick);
        scorpion.Kick();
        scorpion.Jump();
    }
}