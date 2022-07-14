using static System.Console;

//WorkingWithQueue();
WorkingWithPriorityQueue();

static void WorkingWithPriorityQueue()
{
    PriorityQueue<string, int> vaccine = new();
    vaccine.Enqueue("Pamela", 1);
    vaccine.Enqueue("Rebecca", 3);
    vaccine.Enqueue("Barbara", 2);
    vaccine.Enqueue("Frank", 1);

    OutputPQ("Current queue", vaccine.UnorderedItems);

    WriteLine($"{vaccine.Dequeue()} has been vaccinated");
    WriteLine($"{vaccine.Dequeue()} has been vaccinated");
    OutputPQ("Current queue", vaccine.UnorderedItems);

    WriteLine($"{vaccine.Dequeue()} has been vaccinated");
    OutputPQ("Current queue", vaccine.UnorderedItems);

    vaccine.Enqueue("Luke", 2);
    WriteLine($"{vaccine.Peek()} will be the next");
    OutputPQ("Current queue", vaccine.UnorderedItems);
}

static void WorkingWithQueue()
{
    Queue<string> coffee = new();
    coffee.Enqueue("Andrea"); // front of the queue
    coffee.Enqueue("Laura");
    coffee.Enqueue("Beatrice");
    coffee.Enqueue("Simone");
    coffee.Enqueue("Paolo"); // back of the queue
    Output("Initial queue from front to back", coffee);

    string served = coffee.Dequeue();
    WriteLine($"Served: {served}");
    served = coffee.Dequeue();
    WriteLine($"Served: {served}");
    Output("Current queue from front tu back", coffee);

    served = coffee.Dequeue();
    WriteLine($"Served: {served}");
    Output("Current queue from front tu back", coffee);

    WriteLine($"{coffee.Peek()} is next in the line");
    Output("Current queue from front tu back", coffee);
}

static void OutputPQ<TElement, TPriority>(
    string title,
    IEnumerable<(TElement Element, TPriority Priority)> collection)
{
    WriteLine(title);
    foreach ((TElement, TPriority) item in collection)
    {
        WriteLine($"    {item.Item1}: {item.Item2}");
    }
}

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (var item in collection)
    {
        WriteLine($"    {item}");
    }
}