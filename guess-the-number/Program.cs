using System;

namespace Guess_The_Number
{
    class Program
    {
        static void Main(string[] args)
        {
          Random random = new Random();
            var status = true;
            do
            {
                int guess = 0;
                int round = 0;
                double myRandom = random.Next(1, 101); 
                while (guess != myRandom)
                {
                    Console.WriteLine("Guess a number between 1-100: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess :{guess}");
                    if (guess > myRandom)
                    {
                        Console.WriteLine($"{guess} is too high!!");
                    }
                    else if (guess < myRandom)
                    {
                        Console.WriteLine($"{guess} is too low!!!");
                    }
                    round++;
                }

                Console.Clear();
                Console.WriteLine("You win!!!");
                Console.WriteLine("Guess: " + myRandom);
                Console.WriteLine("Round: " + round);
                Console.WriteLine("Would you like to play again? (y/n)");
                var response = Console.ReadLine();
                status = response == "y";


            } while (status);

            Console.WriteLine("thanks for playing");
        }
    }
}