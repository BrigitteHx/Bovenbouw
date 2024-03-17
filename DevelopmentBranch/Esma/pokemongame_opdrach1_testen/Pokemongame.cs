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

            Pokeball pokeball = new Pokeball();


            Battle battle = new Battle();
            battle.Startbattle(trainer1, trainer2, pokeball);

            Arena.DisplayWinner(trainer1, trainer2, battle);

            // if you type "yes", playagain will be true, if you type anything else it will be false
            Console.WriteLine("Do you want to play again? (yes/no)");


            playagain = Console.ReadLine().ToLower() == "yes";
        }

        Console.WriteLine("Thanks for playing!");
    }

}
