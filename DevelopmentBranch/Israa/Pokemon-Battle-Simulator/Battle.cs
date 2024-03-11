using System;

class Battle
{
    // Method to start the battle
    public void StartBattle(Trainer trainer1, Trainer trainer2, Pokeball pokeball , Arena arena)
    {
        Console.WriteLine($"\nPlayer {trainer1.GetName()} VS Player {trainer2.GetName()}!");

        for (int count = 0; count < 6; count++)
        {
            Console.WriteLine($"Round {count + 1}"); // Round number

            // Get the next Pokémon for each player
            Pokemon pokemon1 = trainer1.GetNextPokemon();
            Pokemon pokemon2 = trainer2.GetNextPokemon();

            // player 1 turn
            Player1Turn(trainer1, pokeball, pokemon1);

            // player 2 turn
            Player2Turn(trainer2, pokeball, pokemon2);

            // Check the winner of the round
            arena.CheckWinner(pokemon1 , pokemon2);
            
            Console.WriteLine("---------------"); // Separator
        }
    }

    // Method to the player's 1 turn
    private void Player1Turn(Trainer trainer1, Pokeball pokeball, Pokemon pokemon1)
    {
        trainer1.ThrowPokeball();
        pokeball.Open();

        
        pokeball.ReleaseAndBattleCry(pokemon1);
        pokeball.ReturnPokemon(pokemon1);

        pokeball.Close();
        Console.WriteLine("\n");
    }

    // Method to the player's 2 turn
    private void Player2Turn(Trainer trainer2, Pokeball pokeball, Pokemon pokemon2)
    {
        trainer2.ThrowPokeball();
        pokeball.Open();

        pokeball.ReleaseAndBattleCry(pokemon2);
        pokeball.ReturnPokemon(pokemon2);

        pokeball.Close();
        Console.WriteLine("\n");
    }

}