using static System.Console;

string[] list1 = new[]
{
    "Rachel", "Gareth", "Jonathan", "George"
};
string[] list2 = new[]
{
    "Jack", "Stephen", "Daniel", "Jack", "Jared"
};
string[] list3 = new[]
{
    "Demon", "Jack", "Jack", "Jasmine", "Conor"
};

// print lists "as is"
Output(list1, "List 1");
Output(list2, "List 2");
Output(list3, "List 3");

//some functions
Output(list2.Distinct(), "list2.Distinct()");
Output(list2.DistinctBy(x => x.Substring(0,2))
, "list2.DistinctBy(x => x.Substring(0,2))");
Output(list2.Union(list3), "list2.Union(list3)");
Output(list2.Concat(list3), "list2.Concat(list3)");
Output(list2.Intersect(list3), "list2.Intersect(list3)");
Output(list2.Except(list3), "list2.Except(list3)");
Output(list1.Zip(list2, (l1, l2) =>
    $"{l1} matched with {l2}"), "list1.Zip(list2)");


static void Output(IEnumerable<string> param, string description = "")
{
    if (!string.IsNullOrEmpty(description))
        WriteLine(description);

    Write(" ");

    WriteLine(string.Join(", ", param.ToArray()));
    WriteLine();
}