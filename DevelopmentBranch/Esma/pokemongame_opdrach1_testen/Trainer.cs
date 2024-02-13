using System;
using System.Collections.Generic;

public class Trainer
{
    public string Name { get; private set; }
    private List<Pokeball> belt;

    // constructor
    public Trainer(string name)
    {
        Name = name;

        // list of the belt
        belt = new List<Pokeball>();

        InitializeBelt();
    }


    private void InitializeBelt()
    {
        for (int i = 0; i < 6; i++)
        {
            belt.Add(new Pokeball(false, new Charmander($"Charmander{i + 1}", "Fire", "Water")));
        }
    }

    // throwing the pokeball
    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid pokeball index!");
            return;
        }

        belt[index].ThrowBall();
    }

    // returning the pokeball and closing it
    public void ReturnPokeball(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid pokeball index!");
            return;
        }

        belt[index].CloseBall();
    }

    public void CapturePokemon(Charmander charmander, int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            Console.WriteLine("Invalid pokeball index!");
            return;
        }

        belt[index].Capture(charmander);
    }
}
