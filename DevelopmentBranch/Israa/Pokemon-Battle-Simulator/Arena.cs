using System;

class Arena
{
    // Count the number of battles won by each player
    private int player1Wins;
    private int player2Wins;

    // Count the number of ties
    private int tie;

    // Check the winner of the round
    public void CheckWinner(Pokemon pokemon1 , Pokemon pokemon2)
    {
        // Check the winner of the round
        if (pokemon1.GetStrength() == pokemon2.GetWeakness())
        {
            Console.WriteLine($"{pokemon1.GetNickname()} wins the round!");
            IncrementPlayer1Wins();
        }
        else if (pokemon2.GetStrength() == pokemon1.GetWeakness())
        {
            Console.WriteLine($"{pokemon2.GetNickname()} wins the round!");
            IncrementPlayer2Wins();
        }
        else
        {
            Console.WriteLine("The round is a tie!");
            IncrementTie();
        }
    }

    // Static method to display the winner of the battle
    public static void DisplayWinner(Trainer trainer1, Trainer trainer2, Arena arena)
    {
        // Display the winner of the battle
        if (arena.player1Wins > arena.player2Wins)
        {
            Console.WriteLine($"Player {trainer1.GetName()} wins the battle!");
        }
        else if (arena.player2Wins > arena.player1Wins)
        {
            Console.WriteLine($"Player {trainer2.GetName()} wins the battle!");
        }
        else
        {
            Console.WriteLine("The battle is a tie!");
        }
    }

    // Method to increment player 1's win count
    private void IncrementPlayer1Wins()
    {
        player1Wins++;
    }

    // Method to increment player 2's win count
    private void IncrementPlayer2Wins()
    {
        player2Wins++;
    }

    // Method to increment tie count
    private void IncrementTie()
    {
        tie++;
    }

    // Method to get the score of the battle for player 1
    public int GetPlayer1Wins()
    {
        return player1Wins;
    }

    // Method to get the score of the battle for player 2
    public int GetPlayer2Wins()
    {
        return player2Wins;
    }

    // Method to get the round number
    public int GetRound()
    {
        return 6;
    }

    // Method to get the number of ties
    public int GetTie()
    {
        return tie;
    }
}