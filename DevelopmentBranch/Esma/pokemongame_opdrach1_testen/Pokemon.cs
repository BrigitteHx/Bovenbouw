using System;

abstract class Pokemon
{
    protected string nickname;
    protected string strength;
    protected string weakness;

    protected Pokemon(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    public abstract void BattleCry();

    public string GetNickname() => nickname;
}
