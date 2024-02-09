using System;

public class Charmander
{
    public string nickname;
    public int strength;
    public int weakness;

    public Charmander(string nickname, int strength, int weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;

    }
    public void BattleCry()
    {
        Console.WriteLine(nickname + " says: Charmander, char!");
    }

    public void Attack(Charmander opponent)
    {
        int damage = strength - opponent.weakness;
        if (damage > 0)
        {
            Console.WriteLine($"{nickname} attacks {opponent.nickname} with fire and deals {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{opponent.nickname}'s water weakness nullifies the attack!");
        }
    }

}

public class PokemonBattleSimulator
{
    public static void Main()
    {
        // Creating two Charmander instances
        Charmander charmander1 = new Charmander("Charmy", 15, 5);
        Charmander charmander2 = new Charmander("Flamey", 12, 8);

        // Battle begins
        Console.WriteLine("Battle Start!");
        Console.WriteLine("------------------------");

        // First Charmander attacks
        charmander1.BattleCry();
        charmander1.Attack(charmander2);

        // Second Charmander counterattacks
        charmander2.BattleCry();
        charmander2.Attack(charmander1);

        Console.WriteLine("------------------------");
        Console.WriteLine("Battle End!");
    }
}
