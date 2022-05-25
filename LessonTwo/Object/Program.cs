using System;

namespace Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Paul";
            Console.WriteLine($"{name} is {height} meters tall.");

            //int lenght1 = name.Lenght;
            int lenght2 = ((string)name).Length;
            Console.WriteLine($"{name} has {lenght2} characters");

        }
    }
}
