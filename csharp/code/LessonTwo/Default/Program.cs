using System;

namespace Default
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{default(int)}");
            Console.WriteLine($"{default(double)}");
            Console.WriteLine($"{default(DateTime)}");
            Console.WriteLine($"{default(string)}");
            Console.WriteLine($"{default(bool)}");

            int number = 12;
            Console.WriteLine($"Number is {number}");
            number = default;
            Console.WriteLine($"Number is {number}");
        }
    }
}
