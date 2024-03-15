using System;

class Program
{
    static bool playagain = true;

    // start of program, void means it doesn't return any value
    static void Main()
    {
        StartGame();
    }

    //
    static void StartGame()
    {
        Console.WriteLine("Welcome to the Pokemon Battle Simulator!");

        // while playagain is true, continue the game
        while (playagain)
        {
            // ask for the name, and once the player presses enter save it in trainername_1
            Console.WriteLine("Enter a name for the first trainer: ");
            string trainername_1 = Console.ReadLine().ToLower();


            Console.WriteLine("Enter a name for the second trainer: ");
            string trainername_2 = Console.ReadLine();

            // while the second nameis the same as the first name, ask for a new name
            while (trainername_1 == trainername_2) {
                Console.WriteLine("That name is already taken, choose another name.");

                Console.WriteLine("Enter a name for the second trainer: ");
                trainername_2 = Console.ReadLine();

            }
            

            // create new trainer (instances of the trainer class) 
            var trainer1 = new Trainer(trainername_1);
            var trainer2 = new Trainer(trainername_2);

            StartBattle(trainer1, trainer2, new Pokeball());

            // if you type "yes", playagain will be true, if you type anything else it will be false
            Console.WriteLine("Do you want to play again? (yes/no)");
            playagain = Console.ReadLine().ToLower() == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }


    // function to start battle between the two trainers
    static void StartBattle(Trainer trainer1, Trainer trainer2, Pokeball pokeball)
    {
        // repeating the battle for 6 rounds
        for (int count = 0; count < 6; count++)
        {
            Console.WriteLine($"Round {count + 1}");

            // the trainers throw a pokeball and release a pokemon
            trainer1.ThrowPokeball();
            pokeball.ReleaseAndBattleCry(trainer1.GetNextPokemon());

            trainer2.ThrowPokeball();
            pokeball.ReleaseAndBattleCry(trainer2.GetNextPokemon());

        }
    }

}
