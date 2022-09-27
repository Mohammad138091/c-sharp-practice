using System;

namespace bmi_test_cmd
{
    class Program
    {

        static void Main(string[] args)
        {

            if (args.Length == 0 || args.Length == 3 || args.Length == 4 || args[0] != "bmi")
            {
                Erorr();
                Environment.Exit(0);
            }

            double height, weight;

            switch (args[1])
            {
                case "helps":
                    ShowCommandList();
                    break;
                case "--version":
                    Console.WriteLine("Your version is 1.0");
                    break;
                case "--height":
                    if (args[3] != "--weight")
                    {
                        Erorr();
                        Environment.Exit(0);
                    }
                    height = Convert.ToDouble(args[2]);
                    weight = Convert.ToDouble(args[4]);
                    CalculateBmi(height, weight);
                    break;
                case "--weight":
                    if (args[3] != "--height")
                    {
                        Erorr();
                        Environment.Exit(0);
                    }
                    height = Convert.ToDouble(args[4]);
                    weight = Convert.ToDouble(args[2]);
                    CalculateBmi(height, weight);
                    break;

                default:
                    Erorr();
                    Environment.Exit(0);
                    break;
            }
        }
        static void ShowCommandList()
        {
            Console.WriteLine("Use this switch to run program:");
            Console.WriteLine("--height            Your height (centimeters)");
            Console.WriteLine("--weight            Your height (kilogram)");
            Console.WriteLine("--version           Show current version");
            Console.WriteLine("--height            Show command list");

        }

        static void Erorr()
        {
            Console.WriteLine("Invalid Command: (");
            Console.WriteLine("Use --helps switch to show help");
        }

        static void CalculateBmi(double height, double weight)
        {
            double bmi = Math.Round(weight / Math.Pow(height / 100, 2));
            Console.WriteLine("Your Bmi is: " + bmi);
            if (bmi <= 18.4)
            {
                Console.WriteLine("You are underweight");
            }
            else if (bmi > 18.4 && bmi <= 24.9)
            {
                Console.WriteLine("You are normal");
            }
            else if (bmi > 24.9 && bmi <= 39.9)
            {
                Console.WriteLine("You are overweight");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("You are obese");
            }
            else
            {
                Console.WriteLine("A mistake has occurred");
            }
        }
    }
}
