using System;

namespace TV_control_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int channel = 0;
            bool status = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"**channel {++channel}**");
                Console.WriteLine("Do you love this channel?(yes/no)");
                var response = Console.ReadLine();
                status = response != "yes";

            } while (status);

            Console.WriteLine($"Enjoy watching channel {channel}");
            Console.WriteLine("^_^");
        }
    }
}
