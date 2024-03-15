using System;

class Charmander : Pokemon
{
    // Constructor
    public Charmander(string nickname) : base(nickname, "fire", "water")
    {
    }

    // Method for battle cry
    public override void BattleCry()
    {
        Console.WriteLine($"{nickname} says: Charamander, char!");
    }
}