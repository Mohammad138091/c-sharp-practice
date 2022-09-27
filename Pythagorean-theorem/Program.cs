using System;

namespace Pythagorean_theorem_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pythagorean theorem: c^2 = a^2 + b^2
            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("The result is " + result);
        }
    }
}
