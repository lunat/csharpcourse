using static System.Console;


WorkingWithLists();

static void Output(string title, IEnumerable<string> collection)
{
    WriteLine(title);
    foreach (var item in collection)
    {
        WriteLine($"    {item}");   
    }
}

static void WorkingWithLists()
{
    List<string> cities = new();
    cities.Add("London");
    cities.Add("Paris");
    cities.Add("Milan");

    List<string> cities2 = new() { "London", "Paris", "Milan" };

    List<string> cities3 = new();
    cities3
        .AddRange(new [] { "London", "Paris", "Milan" });

    Output("Initial List", cities);
    WriteLine($"The first city is {cities[0]}");
    WriteLine($"The last city is {cities[cities.Count-1]}");
    cities.Insert(0, "Sydney");
    Output("After adding one item:", cities);
    cities.RemoveAt(1);
    cities.Remove("Milan");
    Output("After removing two items:", cities);
}