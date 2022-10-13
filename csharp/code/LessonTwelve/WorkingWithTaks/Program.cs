using static System.Console;
using System.Diagnostics;

OutputThreadInfo();
Stopwatch timer = Stopwatch.StartNew();
//-- first
//WriteLine("Running methods synchronously on one thread...");
//MethodA();
//MethodB();
//MethodC();

//-- second
//WriteLine("Running methods asynchronously on multiple threads...");
//Task taskA = new(MethodA);
//taskA.Start();
//Task taskB = Task.Factory.StartNew(MethodB);
//Task taskC = Task.Run(MethodC);
//
//Task[] tasks = { taskA, taskB, taskC };
//Task.WaitAll(tasks);

//-- third
WriteLine("Passing the result of one task as an input to another...");
Task<string> taskServiceThenStoredProc =
    Task.Factory
        .StartNew(CallWebService)
        .ContinueWith(previousTask =>
            CallStoredProcedure(previousTask.Result));

WriteLine($"Result: {taskServiceThenStoredProc.Result}");


WriteLine($"{timer.ElapsedMilliseconds:#,##0}ms elapsed.");



static void OutputThreadInfo()
{
    Thread t = Thread.CurrentThread;
    WriteLine(
        "Thread Id: {0}, Priority {1}, Backgroud {2}, Name {3}"
        , t.ManagedThreadId
        , t.Priority
        , t.IsBackground
        , t.Name ?? "null"
    );
}

static void MethodA()
{
    WriteLine("Starting method A...");
    OutputThreadInfo();
    Thread.Sleep(3000); // simulate 3 seconds of work
    WriteLine("Finished method A.");
}

static void MethodB()
{
    WriteLine("Starting method B...");
    OutputThreadInfo();
    Thread.Sleep(2000); // simulate 2 seconds of work
    WriteLine("Finished method B.");
}

static void MethodC()
{
    WriteLine("Starting method C...");
    OutputThreadInfo();
    Thread.Sleep(1000); // simulate 1 second of work
    WriteLine("Finished method C.");
}

static decimal CallWebService()
{
    WriteLine("Starting call to web service...");
    OutputThreadInfo();
    Thread.Sleep((new Random()).Next(2000, 4000));
    WriteLine("Finished call to web service.");
    return 89.99m;
}

static string CallStoredProcedure(decimal amount)
{
    WriteLine("Starting call Stored Procedure...");
    OutputThreadInfo();
    Thread.Sleep((new Random()).Next(2000, 4000));
    WriteLine("Finished call to stored procedure.");
    return $"12 products cost more than {amount:C}";
}