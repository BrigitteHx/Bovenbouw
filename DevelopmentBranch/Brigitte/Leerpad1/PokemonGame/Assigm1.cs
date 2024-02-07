// Assignment 1 Classes and objects in a pokemon game 

using System;

public class Charmander
{
    private string nickname;
    private string strength;
    private string weakness;

    public Charmander(string? nickname, string strength, string weakness)
    {
        this.nickname = nickname ?? throw new ArgumentNullException(nameof(nickname));
        this.strength = strength;
        this.weakness = weakness;
    }

    public void BattleCryShout()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nickname} powerrr!");
        }
    }

    public void ChangeTheNickname(string? newNickname)
    {
        if (newNickname != null)
        {
            this.nickname = newNickname;
        }
        else
        {
            Console.WriteLine("Nieuwe nickname kan niet null zijn.");
        }
    }
}

class mainProgram
{
    static void Main()
    {
        bool game = true;

        while (game)
        {
            Console.WriteLine("Welkom bij de Pokemon game!");
            Console.WriteLine("Voer een nickname in voor je charmander");
            string? nickname = Console.ReadLine(); // nullable gebruikt, anders waarschuwing

            Charmander charmander = new Charmander(nickname, "vuur!!", "hitte!!");

            Console.WriteLine("Charmander roept zijn kracht op!!");

            charmander.BattleCryShout(); 

            // ------

            while (true)
            {
                Console.WriteLine("Voer een nieuwe nicknaam in om door te gaan of voer 'quit' in om te stoppen");
                string? newNickname = Console.ReadLine(); 

                if (newNickname == "quit")
                {
                    game = false;
                    break;
                }
                else
                {
                    charmander.ChangeTheNickname(newNickname);
                    Console.WriteLine("Charmander roept zijn kracht op!!");
                    charmander.BattleCryShout(); 
                }
            }
        }
    }
}
