using System;
using System.Numerics;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myVar = 5;
            var bigInt = new BigInteger(55555);
            Console.WriteLine(bigInt);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(double.MinValue);


            Console.WriteLine(sizeof(int));
            Console.WriteLine(sizeof(double));
            Console.WriteLine(sizeof(decimal));
            //Console.WriteLine(sizeof(string));

            decimal a = 0.1m;
            decimal b = 0.2m;

            if (a + b == 0.3m)
            {
                Console.WriteLine($" {a} + {b} equals {0.3}");
            }
            else
            {
                Console.WriteLine($" {a} + {b} does NOT equals {0.3}");
            }
            //double a = 0.1;
            //double b = 0.2;

            //if (a + b == 0.3)
            //{
            //    Console.WriteLine($" {a} + {b} equals {0.3}");
            //}
            //else
            //{
            //    Console.WriteLine($" {a} + {b} does NOT equals {0.3}");
            //}
        }
    }
}
