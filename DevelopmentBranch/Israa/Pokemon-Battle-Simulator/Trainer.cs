using System;

class Trainer
{
    private string name;
    private List<Pokemon> belt; // List to store Pokémon
    private int nextPokemonIndex; // Index to keep track of the next Pokémon to be returned / private because it is only used in this class

    // Constructor
    public Trainer(string name)
    {
        this.name = name; // the name of the player
        belt = new List<Pokemon>(); // Create a new list to store Pokémon
        nextPokemonIndex = 0; // the index to the first Pokémon in the list

        // Add six Pokémon to the belt (two of each type)
        for (int index = 0; index < 2; index++)
        {
            belt.Add(new Squirtle("Squirtle"));
            belt.Add(new Charmander("Charmander"));
            belt.Add(new Bulbasaur("Bulbasaur"));
        }

        // Shuffle the belt
        belt = belt.OrderBy(x => Random.Shared.Next()).ToList();

    }

    // Method to throw a pokeball
    internal void ThrowPokeball()
    {
        Console.WriteLine($"Player {name} throws a pokeball!");
        // Logic to throw pokeball
    }

    // Method to return the next Pokémon from the belt and increment the index
    internal Pokemon GetNextPokemon()
    {
        Pokemon nextPokemon = belt[nextPokemonIndex]; // Get the next Pokémon from the belt
        nextPokemonIndex = (nextPokemonIndex + 1) % belt.Count;  // Increment the index and Moving back if necessary to the beginning of the list.
        return nextPokemon; // Return the next Pokémon.
    }

    // Method to get the trainer's name
    internal string GetName()
    {
        return name;
    }
}