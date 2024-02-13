using System;

class Arena
{
    // Static method to display the winner of the battle
    public static void DisplayWinner(Trainer trainer1, Trainer trainer2, Battle battle)
    {
        Console.WriteLine("-------------------------------");

        // Get Round number
        int Rounds = battle.GetRound();

        // Get the score of the battle for each player
        int player1Wins = battle.GetPlayer1Wins();
        int player2Wins = battle.GetPlayer2Wins();

        // Get the number of ties
        int tie = battle.GetTie();

        // Display the score of the battle for each player
        Console.WriteLine($"Player {trainer1.GetName()} VS Player {trainer2.GetName()}");
        Console.WriteLine($"Rounds: {Rounds}");

        Console.WriteLine($"Player {trainer1.GetName()}: {player1Wins} Rounds");
        Console.WriteLine($"Player {trainer2.GetName()}: {player2Wins} Rounds");
        Console.WriteLine($"Ties: {tie} Rounds");

        // Display the winner of the battle
        if (player1Wins > player2Wins)
        {
            Console.WriteLine($"Player {trainer1.GetName()} wins the battle!");
        }
        else if (player2Wins > player1Wins)
        {
            Console.WriteLine($"Player {trainer2.GetName()} wins the battle!");
        }
        else
        {
            Console.WriteLine("The battle is a tie!");
        }

        Console.WriteLine("-------------------------------");

    }
}
