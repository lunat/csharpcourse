using static System.Console;

WriteLine("Fibonacci Imperative:");
RunFibonacciImperative();
WriteLine("Fibonacci Functional:");
RunFibonacciFunctional();

static void RunFibonacciFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of Fibonacci sequence is {1:N0}.",
            arg0: i,
            arg1: FibonacciFunctional(i));
    }
}

static int FibonacciFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibonacciFunctional(term-1)
                + FibonacciFunctional(term-2)
    };


static void RunFibonacciImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of Fibonacci sequence is {1:N0}.",
            arg0: i,
            arg1: FibonacciImperative(i));
    }
}

static int FibonacciImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibonacciImperative(term - 1) 
               + FibonacciImperative(term - 2);
    }
}