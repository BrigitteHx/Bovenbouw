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
        Console.WriteLine($"{GetNickname()}: Bulbasaur!");
        //for (int index = 0; index < 10; index++)
        //{
        //    Console.WriteLine($"{nickname}: Bulbasaur!");
        //}
    }
}