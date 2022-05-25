using System;

namespace Formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string applesText = "Apples";
            int applesCount = 1234;
            string bananasText = "Banans";
            int bananasCount = 5678;
            Console.WriteLine(
                format: "{0, -10} {1,6}"
                , arg0: "Name"
                , arg1: "Count");
            Console.WriteLine(
                format: "{0, -10} {1,6:N2}"
                , arg0: applesText
                , arg1: applesCount);
            Console.WriteLine(
                format: "{0, -10} {1,6:N2}"
                , arg0: bananasText
                , arg1: bananasCount);

            //int numberOfApples = 12;
            //decimal pricePerApple = 0.3M;
            //
            //Console.WriteLine(
            //    format: "{0} apples cost {1:C}"
            //    , arg0: numberOfApples
            //    , arg1: pricePerApple * numberOfApples);
            //
            //string formatted = string.Format(
            //    format: "{0} apples cost {1:C}"
            //    , arg0: numberOfApples
            //    , arg1: pricePerApple * numberOfApples);
            //
            //Console.WriteLine(formatted);


        }
    }
}
