using System;

class Pokeball
{
    // the pokeball is open(true) or closed(false). I
    private bool isOpen = false;

    // Method to open the pokeball
    public void Open()
    {
        isOpen = true; // Set the isOpen field to true
        Console.WriteLine("The pokeball is opened.");
    }

    // Method to release the Pokémon and the Pokémon do its battle cry
    public void ReleaseAndBattleCry(Pokemon pokemon)
    {
        Console.WriteLine($"The pokeball released the {pokemon.GetNickname()} and {pokemon.GetNickname()} does its battle cry.");
        pokemon.BattleCry();
    }

    // Method to return the Pokémon to the pokeball
    public void ReturnPokemon(Pokemon pokemon)
    {
        Console.WriteLine($"The {pokemon.GetNickname()} is returned to the pokeball.");
    }

    // Method to close the pokeball
    public void Close()
    {
        isOpen = false; // Set the isOpen field to false
        Console.WriteLine("The pokeball is closed.");

        Pokemon pokemon = null; // Set the pokemon field to null
    }
}