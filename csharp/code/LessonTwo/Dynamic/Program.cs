using System;

namespace Dynamic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic something = "Paul";
            something = 12;
            something = new[] { 3, 5, 7 };

            Console.WriteLine($"Length is {something.Length}");
        }
    }
}
