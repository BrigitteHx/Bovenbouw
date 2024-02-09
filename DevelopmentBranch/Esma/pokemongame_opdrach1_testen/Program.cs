using System;
using static System.Net.Mime.MediaTypeNames;

public class Charamander
{
    private string nickname;
    private int strength;
    private int weakness;

    // the constructor:
    public Charamander(string nickname, int strength, int weakness) 
    {
    this.nickname = nickname;
    this.strength = strength;
    this.weakness = weakness;
    }

    public void battlecry()
    {
        Console.WriteLine($"{nickname} says: Charmander, char!");
    }

  

}

public class Pokemongame
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Pokemon battle simulator ");

        do
        {
            Console.WriteLine("Enter a name for your charamander: ");
            string charamandername = Console.ReadLine();
            Charamander charamander = new Charamander(charamandername, 15, 5);
            Console.WriteLine($"Your charamaner, {charamandername}, is ready for battle!");
            for (int i = 0; i < 10; i++)
            {
                charamander.battlecry();
            }

            Console.WriteLine("Do you want to give a new name to your Charmander? (yes/no)");
            string userInput = Console.ReadLine().ToLower();

            if (userInput != "yes")
            {
                Console.WriteLine("Thanks for playing, goodbye!");
                break;
            }
            
            

        } while (true);
    }
}
