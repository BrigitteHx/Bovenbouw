using System;
// Charmander class
class Charmander
{
    // Fields
    private string nickname;
    private string strength;
    private string weakness;

    // Constructor
    public Charmander(string nickname)
    {
        this.nickname = nickname;
        this.strength = "fire";
        this.weakness = "water";
    }

    // Method for battle cry
    public void BattleCry()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Charmander: Charmander!");
        }
    }

    // Method to get nickname
    public string GetNickname()
    {
        return nickname;
    }
}


