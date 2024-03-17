using System;
using System.Collections.Generic;

class Trainer
{
    private string name;
    private List<Pokemon> belt;
    private int nextPokemonIndex;

    // constructor
    public Trainer(string name)
    {
        this.name = name;
        belt = new List<Pokemon>();
        nextPokemonIndex = 0;

        // Array of all available Pokemon
        Pokemon[] allPokemon = {
            new Squirtle("Squirtle"),
            new Charmander("Charmander"),
            new Bulbasaur("Bulbasaur")
            // Add more Pokemon instances if needed
        };

        Random random = new Random();

        // Add 6 random Pokemon to the belt
        for (int index = 0; index < 6; index++)
        {
            Pokemon randomPokemon = allPokemon[random.Next(allPokemon.Length)];
            belt.Add(randomPokemon);
        }
    }

    // method to throw pokeball
    public void ThrowPokeball()
    {
        Console.WriteLine($"Trainer {name} throws a pokeball!");
    }

    // method to return next pokemon from belt
    public Pokemon GetNextPokemon()
    {
        var nextPokemon = belt[nextPokemonIndex++];
        nextPokemonIndex %= belt.Count;
        return nextPokemon;
    }

    public string GetName() => name;
}
