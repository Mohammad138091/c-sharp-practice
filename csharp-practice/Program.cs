using System;

namespace csharp_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of elements to be stored in the array: ");
            var s1 = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[s1];

            for (int i = 0; i < s1; i++)
            {
                Console.Write($"element - {i}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }


            //To find maximum of the numbers
            int maximum = FindMaximum(numbers);
            Console.WriteLine("Maximum element is: " + maximum);
            //To find minimum of the numbers
            int minimum = FindMinimum(numbers);
            Console.WriteLine("Minimum element is: " + minimum);

            //To power one number to another number
            int pow = Pow(3, 4);
            Console.WriteLine(pow);

        }

        static int FindMaximum(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }

            }
            return max;
        }
        static int FindMinimum(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

            }
            return min;
        }

        static int Pow(int x, int y)
        {
            int pow = 1;

            for (int i = 0; i < y; i++)
            {
                pow *= x;

            }
            return pow;
        }
    }
}
