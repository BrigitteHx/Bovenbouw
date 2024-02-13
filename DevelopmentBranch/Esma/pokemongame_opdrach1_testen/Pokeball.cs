using System;

public class Pokeball
{
    private bool open;
    private Charmander charmander;

    public Pokeball(bool open, Charmander charmander)
    {
        this.open = open;
        this.charmander = charmander;
    }

    public void ThrowBall()
    {
        Console.WriteLine($"{charmander} is released!");
        charmander.BattleCryShout();
        open = true;
    }

    public void CloseBall()
    {
        Console.WriteLine($"{charmander} returns to the pokeball!");
        open = false;
    }

    public bool IsOpen()
    {
        return open;
    }

    public Charmander GetCharmander()
    {
        return charmander;
    }

    public void Capture(Charmander charmander)
    {
        Console.WriteLine($"{charmander} is captured!");
    }
}
