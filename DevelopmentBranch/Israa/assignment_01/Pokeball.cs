using System;

// Pokeball class
class Pokeball
{
    private bool isOpen = false;  // Field to store whether the pokeball is open
    private Charmander charmander;

    // Method to open the pokeball
    public void Open()
    {
        isOpen = true; // Set the isOpen field to true
    }

    // Method to release the Charmander
    public void ReleaseCharmander(Charmander pokemon)
    {
        charmander = pokemon;
        charmander.BattleCry();
    }

    // Method to return Charmander to the pokeball
    public void ReturnCharmander()
    {
        charmander = null;
        isOpen = false; // Set the isOpen field to false
    }
}