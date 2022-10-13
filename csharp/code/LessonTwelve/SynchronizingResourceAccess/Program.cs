using System.Diagnostics;
using static System.Console;

WriteLine("Please wait for the tasks to complete");
Stopwatch sw = Stopwatch.StartNew();
Task a = Task.Factory.StartNew(MethodA);
Task b = Task.Factory.StartNew(MethodB);

Task.WaitAll(a, b);
WriteLine();
WriteLine($"Results: {SharedObjects.Message}");
WriteLine($"{sw.ElapsedMilliseconds:N0}ms elapsed");



static void MethodA()
{
    lock (SharedObjects.MyLock)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(SharedObjects.Random.Next(2000));
            SharedObjects.Message += "A";
            Write(".");
        }
    }
}

static void MethodB()
{
    lock (SharedObjects.MyLock)
    {
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(SharedObjects.Random.Next(2000));
            SharedObjects.Message += "B";
            Write(".");
        }
    }
}

static class SharedObjects
{
    public static object MyLock = new();
    public static Random Random = new();
    public static string? Message; // this is the shared resource
}