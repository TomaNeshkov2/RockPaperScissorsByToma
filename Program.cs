using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Welcome to Rock Paper Scissors!");
                Console.WriteLine("Choose [r]ock, [p]aper, or [s]cissors:");
                Console.ResetColor();

                string playerMove = Console.ReadLine().ToLower();

                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissors")
                {
                    playerMove = Scissors;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again...");
                    Console.ResetColor();
                    Console.ReadLine();
                    continue;
                }

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerMove = "";

                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;

                    case 2:
                        computerMove = Paper;
                        break;

                    case 3:
                        computerMove = Scissors;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"The computer chose {computerMove}");
                Console.ResetColor();

                if ((playerMove == Rock && computerMove == Scissors) || (playerMove == Paper && computerMove == Rock) || (playerMove == Scissors && computerMove == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ResetColor();
                }
                else if ((playerMove == Rock && computerMove == Paper) || (playerMove == Paper && computerMove == Scissors) || (playerMove == Scissors && computerMove == Rock))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose!");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("This game was a draw.");
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to play again? [y/n]");
                string playAgainInput = Console.ReadLine().ToLower();

                if (playAgainInput == "y" || playAgainInput == "yes")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Too bad!");
                    break;
                }
            }
        }
    }
}
