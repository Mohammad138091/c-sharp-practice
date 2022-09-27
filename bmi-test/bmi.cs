using System;

namespace Bmi_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight in kg:");
            var weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height in cm:");
            var height = Convert.ToDouble(Console.ReadLine());
            var bmi = weight / Math.Pow(height / 100 , 2);
            if (bmi <= 18.4)
            {
                Console.WriteLine("you are underweight");
            }
            else if (bmi > 18.4 && bmi <= 24.9)
            {
                Console.WriteLine("you are normal");
            }
            else if (bmi > 24.9 && bmi <= 39.9)
            {
                Console.WriteLine("you are overweight");
            }
            else if (bmi >= 40)
            {
                Console.WriteLine("you are obese");
            }
            else
            {
                Console.WriteLine("A mistake has occurred");
            }

        }
    }
}