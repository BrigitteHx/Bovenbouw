using System;

class Squirtle : Pokemon
{
    // Constructor
    public Squirtle(string nickname) : base(nickname, "water", "grass")
    {
    }

    // Method for battle cry
    public override void BattleCry()
    {
        Console.WriteLine($"{GetNickname()}: Squirtle!");
        //for (int index = 0; index < 10; index++)
        //{
        //    Console.WriteLine($"{nickname}: Squirtle!");
        //}
    }
}