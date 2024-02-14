using System;

public class Charmander
{
    private string nickname;
    private string strength;
    private string weakness;

    // constructor
    public Charmander(string? nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        //this.nickname = nickname ?? throw new ArgumentNullException(nameof(nickname));
        this.strength = strength;
        this.weakness = weakness;
    }

    // battlecry
    public void BattleCryShout()
    {
        Console.WriteLine("Enter a name for your charamander: ");
        string nickname = Console.ReadLine();

        Console.WriteLine($"{nickname} says: Charmander, char!");
    }
    

    public void ChangeTheNickname(string? newNickname)
    {
        if (newNickname != null)
        {
            this.nickname = newNickname;
        }
        else
        {
            Console.WriteLine("new nickname can't be null.");
        }
    }
}
