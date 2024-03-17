using System;

class Squirtle : Pokemon
{
    // Constructor
    public Squirtle(string nickname) : base(nickname, "water", "leaf")
    {
    }
    
    // Method for battle cry
    public override void BattleCry()
    {
        Console.WriteLine($"{nickname} says: Squirtle, squirt!");
    }
}
