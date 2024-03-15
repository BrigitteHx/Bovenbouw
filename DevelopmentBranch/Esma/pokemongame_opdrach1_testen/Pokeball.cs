using System;

class Pokeball
{
    // method to release pokemon and do a battlecry
    public void ReleaseAndBattleCry(Pokemon pokemon)
    {
        Console.WriteLine($"{pokemon.GetNickname()} is released!");
        pokemon.BattleCry();
        Console.WriteLine($"{pokemon.GetNickname()} is returned to the pokeball");
    }
}
