using static System.Console;
using System.Diagnostics;

Stopwatch sw = new();
Write("Press ENTER to start.");
ReadLine();
sw.Start();
int max = 45;

IEnumerable<int> numbers = Enumerable.Range(1, max);
WriteLine($"Calculating Fibonacci sequence up to {max}. Please wait...");
int[] fibonacciNumbers = numbers
    .AsParallel()
    .Select(number => Fibonacci(number))
    .OrderBy(number => number)
    .ToArray();
sw.Stop();

WriteLine("{0:#,##0} elapsed milliseconds", sw.ElapsedMilliseconds);

Write("Results");

foreach (var number in fibonacciNumbers)
{
    Write($"  {number}");
}

static int Fibonacci(int term) => 
    term switch
    {
        1 => 0,
        2 => 1,
        _ => Fibonacci(term - 1) + Fibonacci(term - 2)
    };