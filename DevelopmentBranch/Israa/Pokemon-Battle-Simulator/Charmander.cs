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
        Console.WriteLine($"{GetNickname()}: Charmander!");
        //for (int index = 0; index < 10; index++)
        //{
        //    Console.WriteLine($"{nickname}: Charmander!");
        //}
    }
}
