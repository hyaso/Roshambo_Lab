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
        public override Roshambo GenerateRoshambo()
        {
            choice = Roshambo.Rock;
            return choice;
        }
    }

    class RandomPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Random rps = new Random();
            int num = rps.Next(3);
            choice = (Roshambo)num;
            return choice;

        }
    }

    class HumanPlayer : Player
    {

        public HumanPlayer()
        {
            Console.Write("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine();
        }

        public override Roshambo GenerateRoshambo()
        {
            Console.WriteLine();
            Console.WriteLine($"{playerName}, choose Rock, Paper, or Scissors");
            string userChoice = Console.ReadLine().ToUpper();
            if (userChoice == "ROCK")
            {
                choice = Roshambo.Rock;
            }
            else if (userChoice == "PAPER")
            {
                choice = Roshambo.Paper;
            }
            else if (userChoice == "SCISSORS")
            {
                choice = Roshambo.Scissors;
            }
            return choice;
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            HumanPlayer player1 = new HumanPlayer();
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Would you like to play against the Rock Thrower or a Random Player?");
                string userChoice = Console.ReadLine().ToUpper();

                if (userChoice == "ROCK THROWER")
                {
                    player1.GenerateRoshambo();
                    RockPlayer rockOpp = new RockPlayer();
                    rockOpp.GenerateRoshambo();

                    if ((rockOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Rock)
                       || (rockOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Paper)
                       || (rockOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Scissors))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Rock thrower chose: {rockOpp.choice}");
                        Console.WriteLine("It is a draw!");
                    }

                    else if ((rockOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Paper)
                        || (rockOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Rock)
                        || (rockOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Scissors))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Rock thrower chose: {rockOpp.choice}");
                        Console.WriteLine("You win!");
                    }

                    else if ((rockOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Scissors)
                        || (rockOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Rock)
                        || (rockOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Paper))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Rock thrower chose: {rockOpp.choice}");
                        Console.WriteLine("You lose!");
                    }
                }

                else if (userChoice == "RANDOM PLAYER")
                {
                    player1.GenerateRoshambo();
                    RandomPlayer randomOpp = new RandomPlayer();
                    randomOpp.GenerateRoshambo();

                    if ((randomOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Rock)
                       || (randomOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Paper)
                       || (randomOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Scissors))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Random player chose: {randomOpp.choice}");
                        Console.WriteLine("It is a draw!");
                    }

                    else if ((randomOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Paper)
                        || (randomOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Rock)
                        || (randomOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Scissors))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Random player chose: {randomOpp.choice}");
                        Console.WriteLine("You win!");
                    }

                    else if ((randomOpp.choice == Roshambo.Rock && player1.choice == Roshambo.Scissors)
                        || (randomOpp.choice == Roshambo.Paper && player1.choice == Roshambo.Rock)
                        || (randomOpp.choice == Roshambo.Scissors && player1.choice == Roshambo.Paper))
                    {
                        Console.WriteLine($"You chose: {player1.choice}. Random player chose: {randomOpp.choice}");
                        Console.WriteLine("You lose!");
                    }
                }

                else
                {
                    Console.WriteLine("That is not a valid choice!");
                }

                Console.WriteLine();
                Console.WriteLine("Would you like to play again?");
                string answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y" || answer == "YES")
                {
                    Console.WriteLine();
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing!");
                }

                

            }



            Console.ReadKey();
           

        }
    }
 
}
