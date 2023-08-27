using System;

namespace Strategy.Contracts;

abstract class CharacterBase
{
    private IKickType _kickType;
    private IJumpType _jumpType;

    protected CharacterBase(IKickType kickType, IJumpType jumpType)
    {
        _kickType = kickType;
        _jumpType = jumpType;
    }

    public void Kick() => _kickType.Kick();
    public void Jump() => _jumpType.Jump();

    public void SetKickType(IKickType kickType) => _kickType = kickType;
    public void SetJumpType(IJumpType jumpType) => _jumpType = jumpType;

    public void Hit() => Console.WriteLine("Hit");
    public abstract void IntroduceCharacter();
}
