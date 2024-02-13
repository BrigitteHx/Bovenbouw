using System;

class Battle
{
    // Count the number of wins for each player
    public int player1Wins;
    public int player2Wins;
    public int tie;

    // Method to start the battle
    public void StartBattle(Trainer trainer1, Trainer trainer2, Pokeball pokeball)
    {
        Console.WriteLine($"Player {trainer1.GetName()} VS Player {trainer2.GetName()}!");

        for (int count = 0; count < 6; count++)
        {
            Console.WriteLine($"Round {count + 1}"); // Round number

            // Player 1 throws the pokeball
            trainer1.ThrowPokeball();

            // Get the next Pokémon from the trainer
            Pokemon pokemon1 = trainer1.GetNextPokemon();

            // Release Pokémon from the pokeball, and the Pokémon do its battle cry
            pokeball.ReleaseAndBattleCry(pokemon1);
            Console.WriteLine("\n");

            // Player 2 throws the first pokeball
            trainer2.ThrowPokeball();

            // Get the next Pokémon from the trainer
            Pokemon pokemon2 = trainer2.GetNextPokemon();

            // Release Pokémon from the pokeball, and the Pokémon do its battle cry
            pokeball.ReleaseAndBattleCry(pokemon2);


            // Check the winner of the battle
            
            if (pokemon1.GetStrength() == pokemon2.GetWeakness())
            {
                Console.WriteLine($"{pokemon1.GetNickname()} wins!");
                player1Wins++;
            }
            else if (pokemon2.GetStrength() == pokemon1.GetWeakness())
            {
                Console.WriteLine($"{pokemon2.GetNickname()} wins!");
                player2Wins++;
            }
            else
            {
                Console.WriteLine("It's a tie!");
                tie++;
            }

            // Check the winner of the 

            Console.WriteLine("---------------"); // Separator
        }
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


//Console.WriteLine("-------------------------------------------")
//        Console.WriteLine("The battle is over!\nResults: ");

// Display the score of the battle for each player
// Console.WriteLine($"Player {trainer1.GetName()} VS Player {trainer2.GetName()}");

//Console.WriteLine($"Player {trainer1.GetName()}: {player1Wins} wins");
//Console.WriteLine($"Player {trainer2.GetName()}: {player2Wins} wins");
