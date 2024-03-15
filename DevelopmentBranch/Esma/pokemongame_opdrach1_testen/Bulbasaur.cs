using System;

class Bulbasaur : Pokemon
{
    // Constructor
    public Bulbasaur(string nickname) : base(nickname, "grass", "fire")
    {
    }
    // Method for battle cry
    public override void BattleCry()
    {
        Console.WriteLine($"{nickname} says: Bulbasaur, bulba!");

    }
}