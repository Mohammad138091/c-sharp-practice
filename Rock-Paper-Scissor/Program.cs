using System;

namespace rock_paper_scissor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            do
            {
                string user = GetUser();

                string computer = GetComputerRound();

                ResultGame(user, computer);

                status = PlayAgain();

                

            } while (status);

            Console.WriteLine("Thanks for playing");

        }

        static void ResultGame(string user, string value)

        {
            if (user.ToUpper() == value)
            {
                Console.WriteLine("It's a draw");

            }

            switch (user.ToUpper())
            {
                case "ROCK":
                    if (value == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (value == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSOR":
                    if (value == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;

            }

        }

        static string GetUser()
        {
            string user = "";
            do
            {
                Console.WriteLine("Enter ROCK, PAPER OR SCISSOR: ");
                user = Console.ReadLine();
                Console.WriteLine("Player: " + user.ToUpper());


            } while (user.ToUpper() != "ROCK" && user.ToUpper() != "PAPER" && user.ToUpper() != "SCISSOR");
            return user;
        }

        static string GetComputerRound()
        {
            Random rnd = new Random();

            string[] array = { "ROCK", "PAPER", "SCISSOR" };
            int index = rnd.Next(0, array.Length);
            string computer = array[index];
            Console.WriteLine("Computer: " + computer);
            return computer;
        }

        static bool PlayAgain()
        {
                bool status = true;
                Console.WriteLine("Would you like to play again?(y/n)");
                var response = Console.ReadLine();
                status = response == "y";
                return status;
        }
    }
}
