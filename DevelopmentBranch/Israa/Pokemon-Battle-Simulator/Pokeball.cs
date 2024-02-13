using System;

class Pokeball
{
    // Method to release the Pokémon
    public void ReleaseAndBattleCry(Pokemon pokemon)
    {
        Console.WriteLine($"The pokeball is thrown, which opens it up and releases {pokemon.GetNickname()}!\nThe {pokemon.GetNickname()} does its battle cry.");
        pokemon.BattleCry();
        Console.WriteLine($"The {pokemon.GetNickname()} is returned to the pokeball.");
    }    
}


// ------------------------------------------------ klemboard ------------------------------------------------


// Pokeball class
//lass Pokeball
//{
// the pokeball is open(true) or closed(false). I
//    private bool isOpen = false;  // Field to store whether the pokeball is open
//    private Charmander charmander;

// Method to open the pokeball
//    public void Open()
//    {
//        isOpen = true; // Set the isOpen field to true
//    }

// Method to release the Charmander
//    public void ReleaseAndBattleCry(Charmander pokemon)
//    {
///        Console.WriteLine("The pokeball released the charmander and charmander does its battle cry.");
//        charmander = pokemon;
//        charmander.BattleCry();
//    }

// Method to return Charmander to the pokeball
//    public void ReturnCharmander()
//    {
//        charmander = null;
//        isOpen = false; // Set the isOpen field to false
//    }
//}