using System;

public class Pokemongame
{
    public static void Main()
    {
        bool game = true;

        while (game)
        {
            Console.WriteLine("Welcome to the Pokemon Battle simulator!");
            Trainer trainer1 = CreateTrainer("Player 1");
            Trainer trainer2 = CreateTrainer("Player 2");
            Console.WriteLine("Trainers created successfully.");

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{trainer1.Name} throws a pokeball");
                trainer1.ThrowPokeball(0);

                Console.WriteLine($"{trainer2.Name} throws a pokeball");
                trainer2.ThrowPokeball(0);

                Console.WriteLine($"{trainer1.Name} returns a pokeball");
                trainer1.ReturnPokeball(0);

                Console.WriteLine($"{trainer2.Name} returns a pokeball");
                trainer2.ReturnPokeball(0);
            }


            Console.WriteLine("Do you want to play again? (yes/no)");
            Console.WriteLine("\n");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
            {
                Console.WriteLine("Thanks for playing! Goodbye!");
                game = false;
            }
        }
        Console.ReadLine();
    }

    private static Trainer CreateTrainer(string player)
    {
        Console.WriteLine($"Enter a name for {player}'s trainer:");
        string trainerName = Console.ReadLine();
        return new Trainer(trainerName);
    }
}
