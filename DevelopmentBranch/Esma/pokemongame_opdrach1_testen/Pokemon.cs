using System;

abstract class Pokemon // Abstract class for Pokemon
{
    // Fields
    protected string nickname;
    protected string strength;
    protected string weakness;

    // Constructor
    protected Pokemon(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    // Abstract method for battle cry
    public abstract void BattleCry();

    // Method to get strength
    public string GetStrength()
    {
        return strength;
    }

    // Method to get weakness
    public string GetWeakness()
    {
        return weakness;
    }

    // Method to get nickname
    public string GetNickname()
    {
        return nickname;
    }
}