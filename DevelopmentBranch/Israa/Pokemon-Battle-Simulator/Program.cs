using System;
using System.Collections.Generic;

class Program
{
    // Static so it can be accessed from anywhere and it's value is shared across all instances of the class
    public static bool playAgain = true;

    static void Main(string[] args) // void means the method does not return a value
    {
        StartGame();
    }

    // Method to start the game
    static void StartGame()
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

        // While loop to keep playing the game
        while (playAgain)
        {
            // Ask for a name for the first trainer
            Console.WriteLine("Enter a name for the first trainer or 'quit' to exit:");
            string trainer1Name = Console.ReadLine();

            if (trainer1Name.ToLower() == "quit")
            {
                playAgain = false;
                break;
            }

            // Ask for a name for the second trainer
            Console.WriteLine("Enter a name for the second trainer:");
            string trainer2Name = Console.ReadLine();

            // Create trainers/players
            Trainer trainer1 = new Trainer(trainer1Name);
            Trainer trainer2 = new Trainer(trainer2Name);

            // Create a new pokeball for each battle
            Pokeball pokeball = new Pokeball();

            // Create a new arena for each battle
            Arena arena = new Arena();

            // Start the battle with the pokeball
            Battle battle = new Battle();
            battle.StartBattle(trainer1, trainer2, pokeball, arena);

            // Create a new arena for each battle
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"Player {trainer1.GetName()} VS Player {trainer2.GetName()}");
            Console.WriteLine($"Rounds: {arena.GetRound()}");

            Console.WriteLine($"Player {trainer1.GetName()}: {arena.GetPlayer1Wins()} Rounds");
            Console.WriteLine($"Player {trainer2.GetName()}: {arena.GetPlayer2Wins()} Rounds");
            Console.WriteLine($"Ties: {arena.GetTie()} Rounds");

            Arena.DisplayWinner(trainer1, trainer2, arena);
            Console.WriteLine("-------------------------------");


            // Ask if the player wants to play again
            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainResponse = Console.ReadLine();
            if (playAgainResponse.ToLower() == "no")
            {
                playAgain = false;
            }

        }

        Console.WriteLine("Thanks for playing!");
    }

}