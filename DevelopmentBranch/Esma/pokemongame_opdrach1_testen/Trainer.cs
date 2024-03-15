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

        // add 6 pokemons to the belt
        for (int index = 0; index < 6; index++)
        {
            belt.AddRange(new Pokemon[] {
                new Squirtle("Squirtle"),
                new Charmander("Charmander"),
                new Bulbasaur("Bulbasaur")
            });
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
