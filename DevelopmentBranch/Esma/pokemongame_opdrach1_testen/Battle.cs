using System;

class Battle
{
    // Count the number of wins
    public int pokemon1wins;
    public int pokemon2wins;
    public int tie;


    // function to start battle between the two trainers
    public void Startbattle(Trainer trainer1, Trainer trainer2, Pokeball pokeball)
    {
        // repeating the battle for 6 rounds
        for (int count = 0; count < 6; count++)
        {
            Console.WriteLine($"Round {count + 1}");

            // the trainers throw a pokeball and release a pokemon
            trainer1.ThrowPokeball();
            Pokemon pokemon1 = trainer1.GetNextPokemon();
            pokeball.ReleaseAndBattleCry(pokemon1);

            trainer2.ThrowPokeball();
            Pokemon pokemon2 = trainer1.GetNextPokemon();
            pokeball.ReleaseAndBattleCry(pokemon2);



            if (pokemon1.GetStrength() == "fire" && pokemon2.GetStrength() == "grass")
            {
                Console.WriteLine($"{pokemon1.GetNickname()} wins!");
                pokemon1wins++;
            }
            else if (pokemon1.GetStrength() == "grass" && pokemon2.GetStrength() == "fire")
            {
                Console.WriteLine($"{pokemon2.GetNickname()} wins!");
                pokemon2wins++;
            }

            else if (pokemon1.GetStrength() == "grass" && pokemon2.GetStrength() == "water")
            {
                Console.WriteLine($"{pokemon1.GetNickname()} wins!");
                pokemon1wins++;
            }
            else if (pokemon1.GetStrength() == "water" && pokemon2.GetStrength() == "grass")
            {
                Console.WriteLine($"{pokemon2.GetNickname()} wins!");
                pokemon2wins++;
            }

            else if (pokemon1.GetStrength() == "water" && pokemon2.GetStrength() == "fire")
            {
                Console.WriteLine($"{pokemon1.GetNickname()} wins!");
                pokemon1wins++;
            }
            else if (pokemon1.GetStrength() == "fire" && pokemon2.GetStrength() == "water")
            {
                Console.WriteLine($"{pokemon2.GetNickname()} wins!");
                pokemon2wins++;
            }

            else if (pokemon2 == pokemon1)
            {
                Console.WriteLine("It's a tie!");
                tie++;
            }

        }

    }

    // Method to get the score of the battle for player 1
    public int GetPlayer1Wins()
    {
        return pokemon1wins;
    }

    // Method to get the score of the battle for player 2
    public int GetPlayer2Wins()
    {
        return pokemon2wins;
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
