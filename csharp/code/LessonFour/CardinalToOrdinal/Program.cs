using CardinalToOrdinal.Helpers;
using static System.Console;

RunCardinalToOrdinal();
WriteLine("Finish!");


static void RunCardinalToOrdinal()
{
    for (int i = 1; i <= 40; i++)
    {
        Write($"{TestClass.CardinalToOrdinal(i)} ");
    }
    WriteLine();
}

