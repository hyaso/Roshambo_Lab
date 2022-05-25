using System;

namespace Roshambo_Lab
{
    enum Roshambo { Rock, Paper, Scissors }

    abstract class Player
    {
        public string playerName;
        public Roshambo choice;

        public virtual Roshambo GenerateRoshambo()
        {
            return choice;
        }
    }

    class RockPlayer : Player
    {
        public string rockPlayer = "Rock Player";
        public override Roshambo GenerateRoshambo()
        {
            choice = Roshambo.Rock;
            Console.WriteLine($"{rockPlayer} chose rock!");

            return choice;
        }
    }

    class RandomPlayer : Player
    {
        public string randomPlayer = "Random Player";
        public override Roshambo GenerateRoshambo()
        {
            Random rps = new Random();
            int num = rps.Next(1, 4);
            Roshambo choice = (Roshambo)num;

            Console.WriteLine($"{randomPlayer} chose {choice}");
            return choice;

        }
    }

    class HumanPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.Write("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{playerName}, choose Rock, Paper, or Scissors");
            string userChoise = Console.ReadLine().ToUpper();
            if (userChoise == "ROCK")
            {
                choice = Roshambo.Rock;
            }
            else if (userChoise == "PAPER")
            {
                choice = Roshambo.Paper;
            }
            else if (userChoise == "SCISSORs")
            {
                choice = Roshambo.Scissors;
            }
            return choice;
        }

       
    }


    class Program
    {
        static void Winner(Player user, Player cpu)
        {
            if (user.choice == cpu.choice)
            {
                Console.WriteLine("It is a draw!");
            }
            else if (user.choice == Roshambo.Rock && cpu.choice == Roshambo.Scissors)
            {
                Console.WriteLine($"The winner is {user}");
            }
            else
            {
                Console.WriteLine($"The winner is {cpu}");
            }
        }

        static void Main(string[] args)
        {
            bool playAgain = true;
            Player opponent;
            string answer;
            string userChoice;

            HumanPlayer player1 = new HumanPlayer();
            player1.GenerateRoshambo();

            while (playAgain)
            {
                Console.WriteLine("Would you like to play against the Rock Thrower or a Random Player?");
                userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "ROCK THROWER")
                {
                    opponent = new RockPlayer();
                }

                else if (userChoice == "RANDOM PLAYER")
                {
                    opponent = new RandomPlayer();
                }

                else
                {
                    Console.WriteLine("That is not a valid choice!");
                }


            }

            Console.WriteLine("would you like to play again?");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y" || answer == "YES")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
           

        }
    }
 
}
