using static System.Console;


RunFactorial();
//extract until you drop

static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        WriteLine($"Factorial {i}! = {Factorial(i):N0}");
        try
        {
            WriteLine($"Factorial {i}! = {Factorial(i):N0}");
        }
        catch (OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer");
        }
    }
}


static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked
        {
            return number * Factorial(number - 1);
        }
    }
}